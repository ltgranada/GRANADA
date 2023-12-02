using Microsoft.AspNetCore.Mvc;
using GranadaITELEC1C.Services;
using GranadaITELEC1C.Models;
using GranadaITELEC1C.Data;

namespace GranadaITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _dbData;
        public StudentController(AppDbContext dbData)
        {
            _dbData = dbData;
        }


        public IActionResult Index()
        {

            return View(_dbData.Students);
        }

        public IActionResult ShowDetails(int id)
        {
            //Search for the instructor whose id matches the given id
            Student? student = _dbData.Students.FirstOrDefault(st => st.Id == id);

            if (student != null)
            {
                if (student.StudentProfilePhoto != null)
                {
                    string imageBase64Data = Convert.ToBase64String(student.StudentProfilePhoto);
                    string imageDataURL = string.Format("data:image/jpg;base64,{0}", imageBase64Data);
                    ViewBag.StudentProfilePhoto = imageDataURL;
                }

                return View(student);


            }//was a student found?

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddStudent()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {
            if (!ModelState.IsValid)
                return View();

            if (Request.Form.Files.Count > 0) // did a user upload a file?
            {
                var file = Request.Form.Files[0];

                MemoryStream ms = new MemoryStream();
                file.CopyTo(ms); //copy the file into a memory stream object
                newStudent.StudentProfilePhoto = ms.ToArray(); // save bytes into newStudent
                ms.Close();
                ms.Dispose();
            }


            _dbData.Students.Add(newStudent);
            _dbData.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {
            //Search for the instructor whose id matches the given id
            Student? student = _dbData.Students.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an instructor found?
                return View(student);

            return NotFound();
        }
        [HttpPost]
        public IActionResult UpdateStudent(Student studentChanges)
        {
            Student? student = _dbData.Students.FirstOrDefault(st => st.Id == studentChanges.Id);

            if (student != null)
            {
                student.FirstName = studentChanges.FirstName;
                student.LastName = studentChanges.LastName;
                student.Email = studentChanges.Email;
                student.AdmissionDate = studentChanges.AdmissionDate;
                student.GPA = studentChanges.GPA;
                student.Course = studentChanges.Course;
               
                _dbData.SaveChanges(); // Save changes after making all the necessary updates
            }

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            //Search for the instructor whose id matches the given id
            Student? student = _dbData.Students.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an instructor found?
                return View(student);

            return NotFound();
        }

        [HttpPost]
        public IActionResult Delete(Student newStudent)

        {
            //Search for the instructor whose id matches the given id
            Student? student = _dbData.Students.FirstOrDefault(st => st.Id == newStudent.Id);

            if (student != null)//was an instructor found?
                _dbData.Students.Remove(student);
            _dbData.SaveChanges();
            return RedirectToAction("Index");
        }
    }
};
