using System;
using System.Collections.Generic;
using TaskList.Domain.Interfaces.Repositories;
using TaskList.Domain.Interfaces.Services;

namespace TaskList.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IService<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;

        public ServiceBase(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual IEnumerable<TEntity> GetAllAsNoTracking()
        {
            return _repository.GetAllAsNoTracking();
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Add(TEntity entity)
        {
            _repository.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }

        public void Remove(TEntity entity)
        {
            _repository.Remove(entity);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
