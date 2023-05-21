using WebApplication2.Context;
using WebApplication2.Data;
using WebApplication2.Migrations;
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

        public EquipamentoModel ListarPorId(int id)
        {
            return _appdbcontext.Equipamentos.FirstOrDefault(x => x.Id == id);
        }

        public EquipamentoModel Atualizar(EquipamentoModel equipamento)
        {
            EquipamentoModel equipamentoDb = ListarPorId(equipamento.Id);

            if (equipamentoDb == null) throw new System.Exception("houve um erro na atualização do equipamento");

            equipamentoDb.Nome = equipamento.Nome;
            equipamentoDb.Khw = equipamento.Khw;
            equipamentoDb.Tempo = equipamento.Tempo;
            equipamentoDb.Quantidade = equipamento.Quantidade;

            _appdbcontext.Equipamentos.Update(equipamentoDb);
            _appdbcontext.SaveChanges() ;

            return equipamentoDb;
        }

        public bool ApagarReal(int id)
        {
            EquipamentoModel equipamentoDb = ListarPorId(id);

            if (equipamentoDb == null) throw new System.Exception("houve um erro na exclusão do equipamento");

            _appdbcontext.Equipamentos.Remove(equipamentoDb);
            _appdbcontext.SaveChanges();

            return true;
        }
    }
}