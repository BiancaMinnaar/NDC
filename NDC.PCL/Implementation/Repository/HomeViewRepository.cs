using System;
using System.Threading.Tasks;
using NDC.Interface.Service;
using NDC.Interface.Repository;
using NDC.Implementation.ViewModel;

namespace NDC.Implementation.Repository
{
    public class HomeViewRepository : ProjectBaseRepository, IHomeViewRepository
    {
        IHomeViewService _Service;

        public HomeViewRepository(IMasterRepository masterRepository, IHomeViewService service)
            : base(masterRepository)
        {
            _Service = service;
        }

        public async Task HomeView(HomeViewViewModel model, Action completeAction)
        {
            await _Service.HomeView(model);
            completeAction();
        }
    }
}