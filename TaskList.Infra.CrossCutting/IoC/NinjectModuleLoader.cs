using Ninject.Modules;
using TaskList.Application;
using TaskList.Application.Interface;
using TaskList.Domain.Interfaces.Repositories;
using TaskList.Domain.Interfaces.Services;
using TaskList.Domain.Services;
using TaskList.Infra.Data.Repositories;

namespace TaskList.Infra.CrossCutting.IoC
{
    public class NinjectModuleLoader : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IAppService<>)).To(typeof(AppServiceBase<>));
            Bind<ITaskAppService>().To<TaskAppService>();

            Bind(typeof(IService<>)).To(typeof(ServiceBase<>));
            Bind<ITaskService>().To<TaskService>();

            Bind(typeof(IRepository<>)).To(typeof(RepositoryBase<>));
            Bind<ITaskRepository>().To<TaskRepository>();
        }
    }
}
