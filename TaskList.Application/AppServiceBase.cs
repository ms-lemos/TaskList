using System;
using System.Collections.Generic;
using TaskList.Application.Interface;
using TaskList.Domain.Interfaces.Services;

namespace TaskList.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppService<TEntity> where TEntity : class
    {
        private readonly IService<TEntity> _service;

        public AppServiceBase(IService<TEntity> service)
        {
            _service = service;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _service.GetAll();
        }

        public IEnumerable<TEntity> GetAllAsNoTracking()
        {
            return _service.GetAllAsNoTracking();
        }

        public TEntity GetById(int id)
        {
            return _service.GetById(id);
        }

        public void Add(TEntity entity)
        {
            _service.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _service.Update(entity);
        }

        public void Remove(TEntity entity)
        {
            _service.Remove(entity);
        }

        public void Dispose()
        {
            _service.Dispose();
        }
    }
}
