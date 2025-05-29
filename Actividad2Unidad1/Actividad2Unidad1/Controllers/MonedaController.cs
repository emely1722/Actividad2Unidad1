using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class MonedaController : Controller
    {
        [HttpPost]
        public IActionResult ConvertirMoneda(decimal monto, string divisa)
        {
            decimal tasaUSD = 60.60m; 
            decimal tasaEUR = 70.50m;
            decimal resultado = 0;

            switch (divisa)
            {
                case "USD":
                    resultado = monto / tasaUSD;
                    break;
                case "EUR":
                    resultado = monto / tasaEUR;
                    break;
                default:
                    ViewBag.Mensaje = "Divisa inexistente.";
                    return View("Index");
            }

            ViewBag.Monto = monto;
            ViewBag.Divisa = divisa;
            ViewBag.Resultado = resultado;

            return View("Resultado");
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
