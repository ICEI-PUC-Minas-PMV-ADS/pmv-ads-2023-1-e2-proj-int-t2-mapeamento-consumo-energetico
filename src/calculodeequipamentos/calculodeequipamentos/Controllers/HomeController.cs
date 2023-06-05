
using WebApplication2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace calculodeequipamentos.Controllers
{
	public class HomeController : Controller
	{

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

        [HttpPost]
        public IActionResult Resultado(double consumoTotal, int placasSolares)
        {
            // Armazene os valores no banco de dados ou faça qualquer outra operação necessária

            // Retorne a view "Resultado" com os valores
            return View("Resultado", new { ConsumoTotal = consumoTotal, PlacasSolares = placasSolares });
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}