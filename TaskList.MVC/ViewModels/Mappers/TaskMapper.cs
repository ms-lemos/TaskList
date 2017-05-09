using TaskList.Domain.Entities;
using TaskList.Infra.CrossCutting.Mapping;

namespace TaskList.MVC.ViewModels.Mappers
{
    public class TaskMapper : AutoMapperBase<TaskViewModel, Task>, ITaskMapper
    {
    }
}