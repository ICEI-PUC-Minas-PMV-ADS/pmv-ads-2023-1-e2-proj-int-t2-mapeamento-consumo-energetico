using WebApplication2.Models;

namespace WebApplication2.Repositorio
{
    public interface IEquipamentoRepositorio
    {
        EquipamentoModel ListarPorId(int id);
        List<EquipamentoModel> BuscarTodos();
        EquipamentoModel Adicionar(EquipamentoModel equipamento);
    }
}
