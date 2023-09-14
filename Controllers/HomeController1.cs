using Microsoft.AspNetCore.Mvc;

namespace GranadaITELEC1C.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
