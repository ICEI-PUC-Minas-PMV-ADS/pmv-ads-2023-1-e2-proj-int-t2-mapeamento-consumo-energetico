using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Repositorio;

namespace WebApplication2.Controllers
{
    public class ControllerEquipamentos : Controller
    {
        
        private readonly IEquipamentoRepositorio _equipamentoRepositorio;
        public ControllerEquipamentos(IEquipamentoRepositorio equipamentoRepositorio)
        {
            _equipamentoRepositorio = equipamentoRepositorio;
        }
        public IActionResult Index()
        {
            List<EquipamentoModel> equipamentos = _equipamentoRepositorio.BuscarTodos();

            return View(equipamentos);
        }
        public IActionResult Adicionar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
            EquipamentoRepositorio equipamento = _equipamentoRepositorio.ListarPorId(id);
            return View(equipamento);
        }
        public IActionResult Apagar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(EquipamentoModel equipamento)
        {
            _equipamentoRepositorio.Adicionar(equipamento);
            return RedirectToAction("Index");
        }
    }
}
