
using System.Collections.Generic;
using TaskList.Application.Interface;
using TaskList.Domain.Entities;
using TaskList.Domain.Interfaces.Services;

namespace TaskList.Application
{
    public class TaskAppService : AppServiceBase<Task>, ITaskAppService
    {
        private readonly ITaskService _service;

        public TaskAppService(ITaskService service): base(service)
        {
            _service = service;
        }

        public IEnumerable<Task> ObterTasksExcluidas()
        {
            return _service.ObterTasksExcluidas(_service.GetAllAsNoTracking(true));
        }
    }
}
