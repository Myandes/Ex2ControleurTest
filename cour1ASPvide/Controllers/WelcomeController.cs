using Microsoft.AspNetCore.Mvc;

namespace cour1ASPvide.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult 	WelcomeDefault()
        {
            return Content("Bienvenue dans ma nouvelle application!");
        }
        public IActionResult WelcomeName(string nom, string prenom)
        {
            //return Content("Salut "+ prenom+" "+ nom +" ! Bienvenue dans ma nouvelle application!");
            if (nom == null || prenom == null) {
                return View("erreur");
            }
            ViewData["nom"] = nom;
            ViewData["prenom"] = prenom;
            return View("Welcome");
        }
        public ContentResult Welcome2()
        {
            string texte = "<h2>Bienvenu dans mon site web</h2>";
          
            return Content(texte,"text/html");
        }
        public ViewResult Welcome3()
        {
            return View();
        }
        public IActionResult num4()
        {
            var filePath = "~/pdf/application.pdf";
            return File(filePath,"application/pdf");
        }
     
    }
}
