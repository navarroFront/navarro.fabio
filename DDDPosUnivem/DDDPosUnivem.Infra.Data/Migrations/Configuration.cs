namespace DDDPosUnivem.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration :
        DbMigrationsConfiguration<Contexto.DDDContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;

            //DANGER - somente para ambiente de DESENV
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DDDPosUnivem.Infra.Data.Contexto.DDDContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
