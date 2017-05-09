using System.Collections.Generic;
using System.Linq;
using TaskList.Domain.Entities;
using TaskList.Domain.Interfaces.Repositories;
using TaskList.Domain.Interfaces.Services;

namespace TaskList.Domain.Services
{
    public class TaskService : ServiceBase<Task>, ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
            : base(taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public override IEnumerable<Task> GetAll()
        {
            return _taskRepository.GetAll().Where(t => !t.Excluida);
        }

        public IEnumerable<Task> GetAll(bool incluirExcluidas)
        {
            return incluirExcluidas ? _taskRepository.GetAll() :_taskRepository.GetAll().Where(t => !t.Excluida);
        }

        public override IEnumerable<Task> GetAllAsNoTracking()
        {
            return _taskRepository.GetAllAsNoTracking().Where(t => !t.Excluida);
        }

        public IEnumerable<Task> GetAllAsNoTracking(bool incluirExcluidas)
        {
            return incluirExcluidas ? _taskRepository.GetAllAsNoTracking() : _taskRepository.GetAllAsNoTracking().Where(t => !t.Excluida);
        }

        public IEnumerable<Task> ObterTasksExcluidas(IEnumerable<Task> tasks)
        {
            return tasks.Where(t => t.Excluida);
        }
    }
}
