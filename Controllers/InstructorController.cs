using GranadaITELEC1C.Models;
using Microsoft.AspNetCore.Mvc;

    public class InstructorController : Controller
{
    List<Instructor> InstructorList = new List<Instructor>
            {
                new Instructor()
                {
                    Id= 1,FirstName = "Gabriel",LastName = "Montano", IsTenured = true, rank = Rank.Instructor, HiringDate = DateTime.Parse("2022-08-26")
                },
                new Instructor()
                {
                    Id= 2,FirstName = "Luis",LastName = "Granada", IsTenured = true, rank = Rank.AssistantProfessor, HiringDate = DateTime.Parse("2022-08-27")
                },
                new Instructor()
                {
                    Id= 3,FirstName = "Albert",LastName = "Montano", IsTenured = false, rank = Rank.AssociateProfessor, HiringDate = DateTime.Parse("2022-08-28")
                }
            };
    public IActionResult Index()
    {

        return View(InstructorList);
    }

    public IActionResult ShowDetail(int id)
    {
        //Search for the instructor whose id matches the given id
        Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

        if (instructor != null)//was an student found?
            return View(instructor);

        return NotFound();
    }

}
