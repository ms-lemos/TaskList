

using TaskList.Domain.Entities;
using TaskList.Infra.CrossCutting.Mapping.Interfaces;

namespace TaskList.MVC.ViewModels.Mappers
{
    public interface ITaskMapper : IMappingService<TaskViewModel, Task>
    {
    }
}
