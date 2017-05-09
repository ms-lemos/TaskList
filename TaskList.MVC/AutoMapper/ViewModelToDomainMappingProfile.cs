using AutoMapper;
using TaskList.Domain.Entities;
using TaskList.MVC.ViewModels;

namespace TaskList.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName => "ViewModelToDomainMappings";

        public ViewModelToDomainMappingProfile()
        {
            CreateMap<Task, TaskViewModel>();
        }
    }
}