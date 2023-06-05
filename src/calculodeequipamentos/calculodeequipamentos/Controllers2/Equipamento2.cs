
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Repositorio;

namespace WebApplication2.Controllers
{
    public class Equipamento2 : Controller
    {

        private readonly IEquipamentoRepositorio2 _equipamentoRepositorio;
        public Equipamento2(IEquipamentoRepositorio2 equipamentoRepositorio)
        {
            _equipamentoRepositorio = equipamentoRepositorio;
        }
        public IActionResult Index()
        {
            List<EquipamentoModel> equip = _equipamentoRepositorio.BuscarTodos2();

            return View(equip);
        }

        public IActionResult Editar(int id)
        {
            EquipamentoModel equip = _equipamentoRepositorio.ListarPorId(id);
            return View(equip);
        }
        public IActionResult Apagar(int id)
        {
            EquipamentoModel equip = _equipamentoRepositorio.ListarPorId(id);
            return View(equip);
        }

        public IActionResult ApagarReal(int id)
        {
            _equipamentoRepositorio.ApagarReal(id);
            return RedirectToAction("Index");
        }

        public IActionResult Adicionar(int id)
        {
            return View();
        }



        [HttpPost]
        public IActionResult Criar(EquipamentoModel equip)
        {
            _equipamentoRepositorio.Adicionar2(equip);
            return RedirectToAction("Index");

        }
        [HttpPost]
        public IActionResult Alterar(EquipamentoModel equip)
        {
            _equipamentoRepositorio.Atualizar2(equip);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult RegistrarResultado(EquipamentoModel equip)
        {
            // Código para salvar o equipamento no banco de dados
            _equipamentoRepositorio.Adicionar2(equip);
            return RedirectToAction("Resultado", new { consumoTotal = equip.ConsumoTotal, placasSolares = equip.PlacasSolares });
        }
    }
}