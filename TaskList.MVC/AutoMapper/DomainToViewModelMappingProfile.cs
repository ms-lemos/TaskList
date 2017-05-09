using AutoMapper;
using TaskList.Domain.Entities;
using TaskList.MVC.ViewModels;

namespace TaskList.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName => "ViewModelToDomainMappings";

        public DomainToViewModelMappingProfile()
        {
            CreateMap<TaskViewModel, Task>();
        }
    }
}