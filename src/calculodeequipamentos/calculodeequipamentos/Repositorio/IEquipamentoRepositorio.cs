
using calculodeequipamentos.Models;

namespace calculodeequipamentos.Repositorio
{
    public interface IEquipamentoRepositorio
    {
        List<EquipamentoEletronico> BuscarTodos();
        EquipamentoEletronico Adicionar(EquipamentoEletronico equipamento);
    }
}