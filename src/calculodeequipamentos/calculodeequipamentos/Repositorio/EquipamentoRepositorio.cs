
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
            _bancoContext.Equipamentos.Add(equipamento);
            _bancoContext.SaveChanges();
            return equipamento;
        }


        public List<EquipamentoEletronico> BuscarTodos()
        {
            return _bancoContext.Equipamentos.ToList();
        }
    }
}