using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
public class NumeroController : Controller
{
    [HttpPost]
    public IActionResult VerificarPrimo(int numero)
    {
        bool esPrimo = EsPrimo(numero);
        ViewBag.Mensaje = esPrimo 
            ? $"{numero} Es primo." 
            : $"{numero} No es primo.";

        return View("Resultado");
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    private bool EsPrimo(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}

}
