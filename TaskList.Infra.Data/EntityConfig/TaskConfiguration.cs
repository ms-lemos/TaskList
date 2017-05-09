using System.Data.Entity.ModelConfiguration;
using TaskList.Domain.Entities;

namespace TaskList.Infra.Data.EntityConfig
{
    public class TaskConfiguration : EntityTypeConfiguration<Task>
    {
        public TaskConfiguration()
        {
            HasKey(t => t.TaskId);

            Property(t => t.Titulo).IsRequired().HasMaxLength(200);
        }
    }
}
