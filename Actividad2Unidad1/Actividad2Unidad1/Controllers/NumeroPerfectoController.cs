using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class NumeroPerfectoController : Controller
    {
        [HttpPost]
        public IActionResult VerificarNumeroPerfecto(int num1)
        {
            bool esPerfecto = EsNumeroPerfecto(num1);
            ViewBag.Mensaje = esPerfecto
                ? $"{num1} Es perfecto."
                : $"{num1} No es perfecto.";

            return View("Resultado");
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        private bool EsNumeroPerfecto(int num1)
        {
            int sumaDivisores = 0;
            for (int i = 1; i < num1; i++)
            {
                if (num1 % i == 0)
                {
                    sumaDivisores += i;
                }
            }
            return sumaDivisores == num1;
        }
    }

}