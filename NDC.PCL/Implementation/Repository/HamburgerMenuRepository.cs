using System;
using System.Threading.Tasks;
using NDC.Interface.Service;
using NDC.Interface.Repository;
using NDC.Implementation.ViewModel;

namespace NDC.Implementation.Repository
{
    public class HamburgerMenuRepository : ProjectBaseRepository, IHamburgerMenuRepository
    {
        IHamburgerMenuService _Service;

        public HamburgerMenuRepository(IMasterRepository masterRepository, IHamburgerMenuService service)
            : base(masterRepository)
        {
            _Service = service;
        }

        public async Task HamburgerMenu(HamburgerMenuViewModel model, Action completeAction)
        {
            await _Service.HamburgerMenu(model);
            completeAction();
        }
    }
}