using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class EquipamentoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do aparelho")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o gasto em KHW do aparelho")]
        public double Khw { get; set; }

        [Required(ErrorMessage = "Digite o tempo de uso do aparelho")]
        public double Tempo { get; set; }

        [Required(ErrorMessage = "Digite a quantidade do aparelho")]
        public int Quantidade { get; set; }

        public double Consumo { get; set; }

        public double ConsumoTotal { get; set; }

        public int PlacasSolares { get; set; }
    }

}