using System.Data.Entity.Migrations;
using TaskList.Domain.Entities;
using TaskList.Infra.Data.Context;

namespace TaskList.Infra.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<TaskListContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TaskListContext context)
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

            context.Tasks.AddOrUpdate(t =>
            t.Titulo,
            new Task {Titulo = "Aquele projeto"},
            new Task {Titulo = "Projeto maneiro"},
            new Task {Titulo = "O joão roubou pão"},
            new Task {Titulo = "Olá Supero."},
            new Task {Titulo = "Outro projeto"}
            );
        }
    }
}
