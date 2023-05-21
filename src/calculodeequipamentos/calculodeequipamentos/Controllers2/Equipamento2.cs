
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Repositorio;

namespace WebApplication2.Controllers
{
    public class Equipamento2 : Controller
    {

        private readonly IEquipamentoRepositorio2 _equipamentoRepositorio2;
        public Equipamento2(IEquipamentoRepositorio2 equipamentoRepositorio2)
        {
            _equipamentoRepositorio2 = equipamentoRepositorio2;
        }
        public IActionResult Index()
        {
            List<EquipamentoModel> equip = _equipamentoRepositorio2.BuscarTodos2();

            return View(equip);
        }
        public IActionResult Adicionar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
            EquipamentoRepositorio2 equip = _equipamentoRepositorio2.ListarPorId(id);
            return View(equip);
        }
        public IActionResult Apagar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(EquipamentoModel equip)
        {
            _equipamentoRepositorio2.Adicionar2(equip);
            return RedirectToAction("Index");
        }
    }
}