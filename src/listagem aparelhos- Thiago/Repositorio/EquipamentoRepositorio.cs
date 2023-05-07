using WebApplication2.Context;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Repositorio
{
    public class EquipamentoRepositorio : IEquipamentoRepositorio
    {
        private readonly AppDbContext _appdbcontext;
        public EquipamentoRepositorio(AppDbContext appdbcontext)
        {
            this._appdbcontext = appdbcontext;
        }
        public EquipamentoModel ListarPorId(int id)
        {
            return _appdbcontext.Equipamentos.FirstOrDefault(x => x.Id == id);
        }
        public List<EquipamentoModel> BuscarTodos()
        {
            return _appdbcontext.Equipamentos.ToList();
        }
        public EquipamentoModel Adicionar(EquipamentoModel equipamento)
        {
            _appdbcontext.Equipamentos.Add(equipamento);
            _appdbcontext.SaveChanges();

            return equipamento;
        }

        
    }
}
