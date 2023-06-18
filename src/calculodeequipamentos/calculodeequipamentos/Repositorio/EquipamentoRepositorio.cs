
using calculodeequipamentos.Context;
using calculodeequipamentos.Models;
using System.Linq;

using calculodeequipamentos.Data;

namespace calculodeequipamentos.Repositorio
{
    public class EquipamentoRepositorio : IEquipamentoRepositorio
    {
        private readonly AppDbContext _bancoContext;
        public EquipamentoRepositorio(AppDbContext appdbcontext)
        {
            _bancoContext = appdbcontext;
        }
        public EquipamentoEletronico Adicionar(EquipamentoEletronico equipamento)
        {
            _bancoContext.Equipamentoss.Add(equipamento);
            _bancoContext.SaveChanges();
            return equipamento;
        }


        public List<EquipamentoEletronico> BuscarTodos()
        {
            return _bancoContext.Equipamentoss.ToList();
        }

        public EquipamentoEletronico ListarPorId(int id)
        {
            return _bancoContext.Equipamentoss.FirstOrDefault(x => x.Id == id);
        }

        public EquipamentoEletronico Atualizar2(EquipamentoEletronico equipamento)
        {
            EquipamentoEletronico equipamentoDb = ListarPorId(equipamento.Id);

            if (equipamentoDb == null) throw new System.Exception("houve um erro na atualização do equipamento");

            equipamentoDb.Nome = equipamento.Nome;
            equipamentoDb.Potencia = equipamento.Potencia;
            equipamentoDb.TempoDeUso = equipamento.TempoDeUso;
            equipamentoDb.Quantidade = equipamento.Quantidade;
            equipamentoDb.Consumo = equipamento.Consumo;
          

            _bancoContext.Equipamentoss.Update(equipamentoDb);
            _bancoContext.SaveChanges();

            return equipamentoDb;
        }

        public bool ApagarReal(int id)
        {
            EquipamentoEletronico equipamentoDb = ListarPorId(id);

            if (equipamentoDb == null) throw new System.Exception("houve um erro na exclusão do equipamento");

            _bancoContext.Equipamentoss.Remove(equipamentoDb);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}