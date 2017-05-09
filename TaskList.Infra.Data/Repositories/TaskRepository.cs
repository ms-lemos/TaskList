using System;
using System.Data.Entity;
using TaskList.Domain.Entities;
using TaskList.Domain.Interfaces.Repositories;

namespace TaskList.Infra.Data.Repositories
{
    public class TaskRepository : RepositoryBase<Task>, ITaskRepository
    {
        public override void Remove(Task entity)
        {
            entity.Excluida = true;
            entity.DtExclusao = DateTime.Now;

            Db.Entry(entity).State = EntityState.Modified;

            Db.SaveChanges();
        }

        public override void Update(Task entity)
        {
            if (entity.Concluida)
                entity.DtConclusao = DateTime.Now;
            else
                entity.DtConclusao = null;

            Db.Entry(entity).State = EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
