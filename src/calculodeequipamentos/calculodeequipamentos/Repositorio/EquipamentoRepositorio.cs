
using calculodeequipamentos.Context;
using calculodeequipamentos.Models;

namespace calculodeequipamentos.Repositorio
{
    public class EquipamentoRepositorio : IEquipamentoRepositorio
    {
        private readonly AppDbContext _appdbcontext;
        public EquipamentoRepositorio(AppDbContext appdbcontext)
        {
            this._appdbcontext = appdbcontext;
        }

        public List<EquipamentoEletronico> BuscarTodos()
        {
            return _appdbcontext.MapeamentoConsumo.ToList();
        }
        public EquipamentoEletronico Adicionar(EquipamentoEletronico equipamento)
        {
            _appdbcontext.MapeamentoConsumo.Add(equipamento);
            _appdbcontext.SaveChanges();

            return equipamento;
        }

        public EquipamentoEletronico ListarPorId(int id)
        {
            return _appdbcontext.MapeamentoConsumo.FirstOrDefault(x => x.Id == id);
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
            equipamentoDb.ConsumoTotal = equipamento.ConsumoTotal;
            equipamentoDb.PlacasSolares = equipamento.PlacasSolares;

            _appdbcontext.MapeamentoConsumo.Update(equipamentoDb);
            _appdbcontext.SaveChanges();

            return equipamentoDb;
        }

        public bool ApagarReal(int id)
        {
            EquipamentoEletronico equipamentoDb = ListarPorId(id);

            if (equipamentoDb == null) throw new System.Exception("houve um erro na exclusão do equipamento");

            _appdbcontext.MapeamentoConsumo.Remove(equipamentoDb);
            _appdbcontext.SaveChanges();

            return true;
        }
    }
}