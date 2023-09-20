using Microsoft.AspNetCore.Mvc;
using GranadaITELEC1C.Models;

namespace GranadaITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentList = new List<Student>
            {
                new Student()
                {
                    Id= 1,FirstName = "Jasper",LastName = "Arangali", Course = Course.BSIT, AdmissionDate = DateTime.Parse("2022-08-26"), GPA = 1.5, Email = "jarangali@gmail.com"
                },
                new Student()
                {
                    Id= 2,FirstName = "Lourdes",LastName = "Santos", Course = Course.BSIS, AdmissionDate = DateTime.Parse("2022-08-07"), GPA = 1, Email = "juskolourdes@gmail.com"
                },
                new Student()
                {
                    Id= 3,FirstName = "Jose Goldie",LastName = "Calimlim", Course = Course.BSCS, AdmissionDate = DateTime.Parse("2020-01-25"), GPA = 1.5, Email = "jogoca@gmail.com"
                },
                new Student()
                {
                    Id= 4,FirstName = "Alyannah",LastName = "Roman", Course = Course.BSCS, AdmissionDate = DateTime.Parse("2020-01-25"), GPA = 1.5, Email = "slayyy@gmail.com"
                }
            };
        public IActionResult Index()
        {

            return View(StudentList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

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
            StudentList.Add(newStudent);
            return View("Index", StudentList);
        }

        [HttpGet]   
        public IActionResult UpdateStudent(int id)
        {
            Student? student = StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }
        [HttpPost]
        public IActionResult UpdateStudent(Student studentChanges)
        {
            Student? student = StudentList.FirstOrDefault(st => st.Id == studentChanges.Id);

            if (student != null)
            {
                student.FirstName = studentChanges.FirstName;
                student.LastName = studentChanges.LastName;
                student.Email = studentChanges.Email;
                student.Course = studentChanges.Course;
                student.GPA = studentChanges.GPA;
                student.AdmissionDate = studentChanges.AdmissionDate;
            }

            return View("Index", StudentList);
        }

    }
}