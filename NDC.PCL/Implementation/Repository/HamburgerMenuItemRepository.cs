using System;
using System.Threading.Tasks;
using NDC.Interface.Service;
using NDC.Interface.Repository;
using NDC.Implementation.ViewModel;

namespace NDC.Implementation.Repository
{
    public class HamburgerMenuItemRepository : ProjectBaseRepository, IHamburgerMenuItemRepository
    {
        IHamburgerMenuItemService _Service;

        public HamburgerMenuItemRepository(IMasterRepository masterRepository, IHamburgerMenuItemService service)
            : base(masterRepository)
        {
            _Service = service;
        }

        public async Task HamburgerMenuItem(HamburgerMenuItemViewModel model, Action completeAction)
        {
            await _Service.HamburgerMenuItem(model);
            completeAction();
        }
    }
}