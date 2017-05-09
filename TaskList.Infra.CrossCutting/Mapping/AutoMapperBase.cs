using System.Collections.Generic;
using AutoMapper;
using TaskList.Infra.CrossCutting.Mapping.Interfaces;

namespace TaskList.Infra.CrossCutting.Mapping
{
    public class AutoMapperBase<TViewModel, TDomain> : IMappingService<TViewModel, TDomain>
    {
        
        public TViewModel ToViewModel(TDomain domain)
        {
            return Mapper.Map<TDomain, TViewModel>(domain);
        }

        public IEnumerable<TViewModel> ToViewModelList(IEnumerable<TDomain> domainList)
        {
            return Mapper.Map < IEnumerable<TDomain>,  IEnumerable<TViewModel>>(domainList);
        }

        public TDomain ToDomain(TViewModel viewModel)
        {
            return Mapper.Map<TViewModel, TDomain>(viewModel);
        }

        public IEnumerable<TDomain> ToDomainList(IEnumerable<TViewModel> viewModelList)
        {
            return Mapper.Map<IEnumerable<TViewModel>, IEnumerable<TDomain>>(viewModelList);
        }
    }
}
