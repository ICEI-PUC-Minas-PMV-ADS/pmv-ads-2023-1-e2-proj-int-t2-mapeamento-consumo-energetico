using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace calculodeequipamentos.Models
{
    public class EquipamentoEletronico
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Quantidade { get; set; }
        public int Potencia { get; set; }
        public int TempoDeUso { get; set; }
        public double Consumo { get; set; }


        public double ConsumoTotal { get; set; }

        public int PlacasSolares { get; set; }
    }
}
