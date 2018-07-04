using System.Data.Entity.ModelConfiguration;
using ViaVarejo.Domain.Entities;

namespace ViaVarejo.Infra.Data.EntityConfig
{
    public class CalculoHistoricoLogConfiguration : EntityTypeConfiguration<CalculoHistoricoLog>
    {
        public CalculoHistoricoLogConfiguration()
        {
            HasKey(c => c.ID);

            HasRequired(c => c.AmigoA).WithMany().HasForeignKey(c => c.IDAmigoA);
            HasRequired(c => c.AmigoB).WithMany().HasForeignKey(c => c.IDAmigoB);

            Property(c => c.DistanciaAB).IsRequired();
            Property(c => c.DataInclusao).IsRequired();
        }
    }
}
