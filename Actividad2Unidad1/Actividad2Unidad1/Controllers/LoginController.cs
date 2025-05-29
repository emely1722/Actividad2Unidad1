using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class LoginController : Controller
    {
        [HttpPost]
        public IActionResult ValidarLogin(string user, string contraseña)
        {
            if (user == "admin" && contraseña == "123456")
            {
                return RedirectToAction("Bienvenido");
            }

            ViewBag.Mensaje = "Usuario incorrecto";
            return View("Index");
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Bienvenido()
        {
            return View();
        }
    }
}
