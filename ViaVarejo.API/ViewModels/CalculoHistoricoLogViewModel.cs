using System;
using System.ComponentModel.DataAnnotations;

namespace ViaVarejo.API.ViewModels
{
    public class CalculoHistoricoLogViewModel
    {
        [Key]
        public int IDAmigoA { get; set; }
        [Key]
        public int IDAmigoB { get; set; }
        [Required]
        public decimal DistanciaAB { get; set; }
        [Required]
        public DateTime DataInclusao { get; set; }

        public virtual AmigoViewModel AmigoA { get; set; }
        public virtual AmigoViewModel AmigoB { get; set; }
    }
}