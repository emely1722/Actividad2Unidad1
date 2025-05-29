using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class CalculadoraController : Controller
    {
        [HttpPost]
        public IActionResult Calcular(double num1, double num2, string operacion)
        {
            double resultado = 0;

            switch (operacion)
            {
                case "sumar":
                    resultado = num1 + num2;
                    break;
                case "restar":
                    resultado = num1 - num2;
                    break;
                case "multiplicar":
                    resultado = num1 * num2;
                    break;
                case "dividir":
                    resultado = num2!= 0 ? num1 / num2 : double.NaN; //la funcion "double.NaN" no permite que se divida entre 0
                    break;
                default:
                    ViewBag.Mensaje = "Operación no válida.";
                    return View("Resultado");
            }

            ViewBag.Resultado = resultado;
            ViewBag.Operacion = operacion;
            return View("Resultado");
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}