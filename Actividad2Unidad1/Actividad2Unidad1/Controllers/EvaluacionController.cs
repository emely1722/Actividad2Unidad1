using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class EvaluacionController : Controller
    {
        [HttpPost]
        public IActionResult CalcularPromedio(int cal1, int cal2, int cal3, int cal4)
        {
            double promedio = (cal1 + cal2 + cal3 + cal4) / 4.0;
            string estado;

            if (promedio >= 70)
                estado = "Aprobado";
            else if (promedio >= 60)
                estado = "En recuperación";
            else
                estado = "Reprobado";

            ViewBag.Promedio = promedio;
            ViewBag.Estado = estado;

            return View("Resultado");
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
