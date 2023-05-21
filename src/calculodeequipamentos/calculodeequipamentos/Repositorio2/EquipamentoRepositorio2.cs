using calculodeequipamentos.Context;
using calculodeequipamentos.Repositorio;
using WebApplication2.Context;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Repositorio
{
    public class EquipamentoRepositorio2 : IEquipamentoRepositorio2
    {
        private readonly AppDbContext2 _appdbcontext;
        public EquipamentoRepositorio2(AppDbContext2 appdbcontext)
        {
            this._appdbcontext = appdbcontext;
        }
        public EquipamentoModel ListarPorId(int id)
        {
            return _appdbcontext.Equip.FirstOrDefault(x => x.Id == id);
        }
        public List<EquipamentoModel> BuscarTodos2()
        {
            return _appdbcontext.Equip.ToList();
        }
        public EquipamentoModel Adicionar2(EquipamentoModel equip)
        {
            _appdbcontext.Equip.Add(equip);
            _appdbcontext.SaveChanges();

            return equip;
        }


    }
}
