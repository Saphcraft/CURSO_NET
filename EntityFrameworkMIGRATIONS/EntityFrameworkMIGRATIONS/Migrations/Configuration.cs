namespace EntityFrameworkMIGRATIONS.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EntityFrameworkMIGRATIONS.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFrameworkMIGRATIONS.Models.ContextoEmpleados>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EntityFrameworkMIGRATIONS.Models.ContextoEmpleados context)
        {
            context.Empleados.AddOrUpdate(z => z.Nombre, new Empleado
            {
                IdEmpleado = 1,
                Nombre = "David",
                Apellidos = "Fernandez Huertas",
                Direccion = "Calle Atletico de Madrid",
                Email = "david@mail.com"
            });
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
