using System.Data.Entity.ModelConfiguration;
using ViaVarejo.Domain.Entities;

namespace ViaVarejo.Infra.Data.EntityConfig
{
    public class AmigoConfiguration : EntityTypeConfiguration<Amigo>
    {
        public AmigoConfiguration()
        {
            HasKey(c => c.ID);
            HasIndex(c => new { c.PosX, c.PosY }).IsUnique();

            Property(c => c.Nome).IsRequired().HasMaxLength(100);
            Property(c => c.Endereco).IsRequired().HasMaxLength(100);
            Property(c => c.PosX).IsRequired();
            Property(c => c.PosY).IsRequired();
            Property(c => c.Distancia).IsOptional();
        }
    }
}