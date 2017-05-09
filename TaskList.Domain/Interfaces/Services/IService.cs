using System.Collections.Generic;

namespace TaskList.Domain.Interfaces.Services
{
    public interface IService<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAllAsNoTracking();
        TEntity GetById(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        void Dispose(); 
    }
}