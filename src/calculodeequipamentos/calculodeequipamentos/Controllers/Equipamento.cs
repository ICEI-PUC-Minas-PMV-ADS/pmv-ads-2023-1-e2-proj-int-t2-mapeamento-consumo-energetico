
using calculodeequipamentos.Models;
using calculodeequipamentos.Repositorio;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace calculodeequipamentos.Controllers
{
    public class Equipamento : Controller
    {
        private readonly IEquipamentoRepositorio _equipamentoRepositorio;
        public Equipamento(IEquipamentoRepositorio equipamentoRepositorio)
        {
            _equipamentoRepositorio = equipamentoRepositorio;
        }
        public IActionResult Index()
        {
            List<EquipamentoEletronico> equipamento = _equipamentoRepositorio.BuscarTodos();
            return View(equipamento);
        }
        public IActionResult RegistrarResultado()
        {
            return View();
        }

        public IActionResult Calculadora()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarResultado(EquipamentoModel equipamento)
        {
            // Código para salvar o equipamento no banco de dados

            return RedirectToAction("Resultado", new { consumoTotal = equipamento.ConsumoTotal, placasSolares = equipamento.PlacasSolares });
        }

    }
}


