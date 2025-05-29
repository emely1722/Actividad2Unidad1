using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class BienvenidaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Saludar(string nom)
        {
            ViewBag.Mensaje = $"Hola, {nom}, bienvenido a ASP.NET MVC.";
            return View("Resultado");
        }
    }
}
