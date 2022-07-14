using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    [Route("esercizi-razor")]
    public class EserciziRazorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
