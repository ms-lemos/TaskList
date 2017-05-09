using System.Collections.Generic;
using TaskList.Domain.Entities;

namespace TaskList.Domain.Interfaces.Services
{
    public interface ITaskService : IService<Task>
    {
        IEnumerable<Task> GetAll(bool incluirExcluidas = false);
        IEnumerable<Task> GetAllAsNoTracking(bool incluirExcluidas = false);

        IEnumerable<Task> ObterTasksExcluidas(IEnumerable<Task> tasks);
    }
}