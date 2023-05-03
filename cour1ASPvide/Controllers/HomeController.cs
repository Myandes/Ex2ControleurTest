using Microsoft.AspNetCore.Mvc;

namespace cour1ASPvide.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {
            string texte = "Bienvenue au cour " + id +" ASP.NET Core MVC";
            return Content(texte,"text/html");
        }
        public IActionResult Page2()
        {
           
            return View();
        }

    }
}
