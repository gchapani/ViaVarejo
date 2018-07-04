using System.Data.Entity;
using ViaVarejo.Domain.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System;
using ViaVarejo.Infra.Data.EntityConfig;

namespace ViaVarejo.Infra.Data.Context
{
    public class ViaVarejoDbContext : DbContext
    {
        public ViaVarejoDbContext()
            : base("ViaVarejo")
        {

        }

        public DbSet<Amigo> Amigo { get; set; }
        public DbSet<CalculoHistoricoLog> CalculoHistoricoLog { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new AmigoConfiguration());
            modelBuilder.Configurations.Add(new CalculoHistoricoLogConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataInclusao") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataInclusao").CurrentValue = DateTime.Now;

                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataInclusao").IsModified = false;

                }
            }

            return base.SaveChanges();
        }
    }
}
