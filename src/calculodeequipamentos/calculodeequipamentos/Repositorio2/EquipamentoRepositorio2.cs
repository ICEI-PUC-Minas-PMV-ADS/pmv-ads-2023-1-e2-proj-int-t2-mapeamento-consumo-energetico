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

        public EquipamentoModel ListarPorId(int id)
        {
            return _appdbcontext.Equip.FirstOrDefault(x => x.Id == id);
        }

        public EquipamentoModel Atualizar2(EquipamentoModel equip)
        {
            EquipamentoModel equipDb = ListarPorId(equip.Id);

            if (equipDb == null) throw new System.Exception("houve um erro na atualização do equipamento");

            equipDb.Nome = equip.Nome;
            equipDb.Khw = equip.Khw;
            equipDb.Tempo = equip.Tempo;
            equipDb.Quantidade = equip.Quantidade;
            equipDb.Consumo = equip.Consumo;
            equipDb.ConsumoTotal = equip.ConsumoTotal;
            equipDb. PlacasSolares = equip.PlacasSolares;

            _appdbcontext.Equip.Update(equipDb);
            _appdbcontext.SaveChanges();

            return equipDb;
        }

        public bool ApagarReal(int id)
        {
            EquipamentoModel equipDb = ListarPorId(id);

            if (equipDb == null) throw new System.Exception("houve um erro na exclusão do equipamento");

            _appdbcontext.Equip.Remove(equipDb);
            _appdbcontext.SaveChanges();

            return true;
        }
    }
}