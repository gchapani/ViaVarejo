using System;
using System.Collections.Generic;

namespace ViaVarejo.Domain.Entities
{
    public class CalculoHistoricoLog
    {
        public int ID { get; set; }
        public int IDAmigoA { get; set; }
        public int IDAmigoB { get; set; }
        public decimal DistanciaAB { get; set; }
        public DateTime DataInclusao { get; set; }
        public virtual Amigo AmigoA { get; set; }
        public virtual Amigo AmigoB { get; set; }
    }
}