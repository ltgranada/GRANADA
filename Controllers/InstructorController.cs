using GranadaITELEC1C.Models;
using GranadaITELEC1C.Services;
using Microsoft.AspNetCore.Mvc;

    public class InstructorController : Controller
{
    private readonly IMyFakeDataService _dummyData;

    public InstructorController(IMyFakeDataService dummyData)
    {
        _dummyData = dummyData;
    }
    public IActionResult Index()
    {

        return View(_dummyData.InstructorList);
    }

    public IActionResult ShowDetail(int id)
    {
        //Search for the instructor whose id matches the given id
        Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(st => st.Id == id);

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
        _dummyData.InstructorList.Add(newInstructor);
        return RedirectToAction("Index");
    }

    [HttpGet]
        public IActionResult UpdateInstructor(int id)
        {
        //Search for the instructor whose id matches the given id
        Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(st => st.Id == id);

        if (instructor != null)//was an student found?
            return View(instructor);

        return NotFound();
    }

    [HttpPost]
    public IActionResult UpdateInstructor(Instructor instructorChanges)
    {
        Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(st => st.Id == instructorChanges.Id);
        if (instructor != null)
        {
            instructor.Id = instructorChanges.Id;
            instructor.FirstName = instructorChanges.FirstName;
            instructor.LastName = instructorChanges.LastName;
            instructor.IsTenured = instructorChanges.IsTenured;
            instructor.rank = instructorChanges.rank;
            instructor.HiringDate = instructorChanges.HiringDate;
        }

        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(st => st.Id == id);

        if (instructor != null)//was an instructor found?
            return View(instructor);

        return NotFound();
    }
    [HttpPost]
    public IActionResult Delete(Instructor newInstructor)
    {
        Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(st => st.Id == newInstructor.Id);

        if (instructor != null)
        {
            _dummyData.InstructorList.Remove(instructor);
            return RedirectToAction("Index");
        }

        return RedirectToAction("Index");
    }

}

