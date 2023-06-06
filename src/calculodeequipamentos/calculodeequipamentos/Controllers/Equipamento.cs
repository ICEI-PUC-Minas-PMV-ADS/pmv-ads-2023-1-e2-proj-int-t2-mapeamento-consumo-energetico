
using calculodeequipamentos.Models;
using calculodeequipamentos.Repositorio;
using Microsoft.AspNetCore.Mvc;


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


        public IActionResult Resultado()
        {
            List<EquipamentoEletronico> equipamento = _equipamentoRepositorio.BuscarTodos();

            double consumoTotal = equipamento.Sum(e => e.Consumo);
            int placasSolares = (int)Math.Ceiling(consumoTotal / 300); // Cada placa solar gera 300 kWh por mês

            ViewBag.ConsumoTotal = consumoTotal;
            ViewBag.PlacasSolares = placasSolares;
            return View();
        }

        public IActionResult Editar(int id)
        {
            EquipamentoEletronico equipamento = _equipamentoRepositorio.ListarPorId(id);
            return View(equipamento);
        }
        public IActionResult Apagar(int id)
        {
            EquipamentoEletronico equipamento = _equipamentoRepositorio.ListarPorId(id);
            return View(equipamento);
        }

        public IActionResult ApagarReal(int id)
        {
            _equipamentoRepositorio.ApagarReal(id);
            return RedirectToAction("Index");
        }

        public IActionResult Adicionar()
        {
            return View();
        }

   

     


        [HttpPost]
        public IActionResult Criar(EquipamentoEletronico equipamento)
        {
            _equipamentoRepositorio.Adicionar(equipamento);
            return RedirectToAction("Index");

        }
        [HttpPost]
        public IActionResult Alterar(EquipamentoEletronico equipamento)
        {
            _equipamentoRepositorio.Atualizar2(equipamento);
            return RedirectToAction("Index");
        }
    }
}


