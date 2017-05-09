using System.Collections.Generic;

namespace TaskList.Infra.CrossCutting.Mapping.Interfaces
{
    public interface IMappingService<TViewModel, TDomain>
    {
        TViewModel ToViewModel(TDomain domain);
        IEnumerable<TViewModel> ToViewModelList(IEnumerable<TDomain> domainList);

        TDomain ToDomain(TViewModel viewModel);
        IEnumerable<TDomain> ToDomainList(IEnumerable<TViewModel> viewModelList);
    }
}