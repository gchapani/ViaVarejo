using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ViaVarejo.API.ViewModels
{
    public class AmigoViewModel
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Informe o Nome do Amigo")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(1, ErrorMessage = "Mínimo de {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o Endereço do Amigo")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(1, ErrorMessage = "Mínimo de {0} caracteres")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Informe a posição X do Amigo")]
        [Range(typeof(decimal), "-99", "99")]
        public decimal PosX { get; set; }

        [Required(ErrorMessage = "Informe a posição Y do Amigo")]
        [Range(typeof(decimal), "-99", "99")]
        public decimal PosY { get; set; }

        public decimal Distancia { get; set; }

        public virtual IEnumerable<CalculoHistoricoLogViewModel> CalculoHistoricoLogA { get; set; }
        public virtual IEnumerable<CalculoHistoricoLogViewModel> CalculoHistoricoLogB { get; set; }
    }
}