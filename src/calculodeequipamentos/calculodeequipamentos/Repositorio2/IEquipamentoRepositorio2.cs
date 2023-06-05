using WebApplication2.Models;

namespace WebApplication2.Repositorio
{
    public interface IEquipamentoRepositorio2
    {
        EquipamentoModel ListarPorId(int id);
        List<EquipamentoModel> BuscarTodos2();
        EquipamentoModel Adicionar2(EquipamentoModel equip);
        EquipamentoModel Atualizar2(EquipamentoModel equip);
        bool ApagarReal(int id);
    }
}