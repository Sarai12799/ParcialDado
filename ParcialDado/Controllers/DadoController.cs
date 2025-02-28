using Microsoft.AspNetCore.Mvc;
using ParcialDado.Models;

namespace ParcialDado.Controllers
{
    public class DadoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Calcular(Dado obdado)
        {
            Random rnd = new Random();
            obdado.NumeroGenerado = rnd.Next(1, 40);
            return View("Resultado", obdado);
        }

    }
}
