﻿using GranadaITELEC1C.Data;
using GranadaITELEC1C.Models;
using GranadaITELEC1C.Services;
using GranadaITELEC1C.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class InstructorController : Controller
{
    private readonly AppDbContext _dbData;

    public InstructorController(AppDbContext dbData)
        {
            _dbData = dbData;
        }
    
    public IActionResult Index()
    {

        return View(_dbData.Instructors);
    }

    public IActionResult ShowDetail(int id)
    {
        //Search for the instructor whose id matches the given id
        Instructor? instructor = _dbData.Instructors.FirstOrDefault(st => st.Id == id);

        if (instructor != null)//was an student found?
            return View(instructor);

        return NotFound();

    }

        [HttpGet]
        public IActionResult AddInstructor()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
        if (!ModelState.IsValid)
        {
            return View();
        }
            _dbData.Instructors.Add(newInstructor);
            _dbData.SaveChanges();
            return RedirectToAction("Index");
        }

        

    

    [HttpGet]
        public IActionResult UpdateInstructor(int id)
        {
        //Search for the instructor whose id matches the given id
        Instructor? instructor = _dbData.Instructors.FirstOrDefault(st => st.Id == id);

        if (instructor != null)//was an student found?
            return View(instructor);

        return NotFound();
    }

    [HttpPost]
    public IActionResult UpdateInstructor(Instructor instructorChanges)
    {
        Instructor? instructor = _dbData.Instructors.FirstOrDefault(st => st.Id == instructorChanges.Id);
        if (instructor != null)
        {
            instructor.Id = instructorChanges.Id;
            instructor.FirstName = instructorChanges.FirstName;
            instructor.LastName = instructorChanges.LastName;
            instructor.IsTenured = instructorChanges.IsTenured;
            instructor.rank = instructorChanges.rank;
            instructor.HiringDate = instructorChanges.HiringDate;
           
            _dbData.SaveChanges();
        }

        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        Instructor? instructor = _dbData.Instructors.FirstOrDefault(st => st.Id == id);

        if (instructor != null)//was an instructor found?
            return View(instructor);

        return NotFound();
    }
    [HttpPost]
    public IActionResult Delete(Instructor newInstructor)
    {
        Instructor? instructor = _dbData.Instructors.FirstOrDefault(st => st.Id == newInstructor.Id);

        if (instructor != null)
        {
            _dbData.Instructors.Remove(instructor);
            _dbData.Instructors.Remove(newInstructor);
            _dbData.SaveChanges();
            return RedirectToAction("Index");
        }

        return RedirectToAction("Index");
    }

    

}

