using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using TaskList.Domain.Entities;
using TaskList.Infra.Data.EntityConfig;

namespace TaskList.Infra.Data.Context
{
    public class TaskListContext : DbContext
    {
        public TaskListContext()
            : base("TaskList")
        {

        }

        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new TaskConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DtCriacao") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DtCriacao").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DtCriacao").IsModified = false;

                    if(entry.Property("DtEdicao") != null)
                        entry.Property("DtEdicao").CurrentValue = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }
    }

}
