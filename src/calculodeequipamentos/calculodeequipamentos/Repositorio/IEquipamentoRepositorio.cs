
using calculodeequipamentos.Models;

namespace calculodeequipamentos.Repositorio
{
    public interface IEquipamentoRepositorio
    {

        EquipamentoEletronico ListarPorId(int id);
        List<EquipamentoEletronico> BuscarTodos();
        EquipamentoEletronico Adicionar(EquipamentoEletronico equipamento);
        
        EquipamentoEletronico Atualizar2(EquipamentoEletronico equipamento);
        bool ApagarReal(int id);
    }
}