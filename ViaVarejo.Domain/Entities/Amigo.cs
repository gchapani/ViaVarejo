using System;
using System.Collections.Generic;

namespace ViaVarejo.Domain.Entities
{
    public class Amigo
    {

        public Amigo()
        {
            CalculoHistoricoLogA = new HashSet<CalculoHistoricoLog>();
            CalculoHistoricoLogB = new HashSet<CalculoHistoricoLog>();
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public decimal PosX { get; set; }
        public decimal PosY { get; set; }
        public decimal? Distancia { get; set; }
        public virtual IEnumerable<CalculoHistoricoLog> CalculoHistoricoLogA { get; set; }
        public virtual IEnumerable<CalculoHistoricoLog> CalculoHistoricoLogB { get; set; }
    }
}