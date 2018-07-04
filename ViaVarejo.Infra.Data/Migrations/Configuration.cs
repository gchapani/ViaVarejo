namespace ViaVarejo.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.ViaVarejoDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        protected override void Seed(Context.ViaVarejoDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
