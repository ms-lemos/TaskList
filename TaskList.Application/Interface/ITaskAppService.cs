using System.Collections.Generic;
using TaskList.Domain.Entities;

namespace TaskList.Application.Interface
{
    public interface ITaskAppService : IAppService<Task>
    {
        IEnumerable<Task> ObterTasksExcluidas();
    }
}