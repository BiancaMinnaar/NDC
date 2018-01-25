using System;
using System.Threading.Tasks;
using NDC.Implementation.ViewModel;

namespace NDC.Interface.Repository
{
    public interface IHamburgerMenuItemRepository
    {
        Task HamburgerMenuItem(HamburgerMenuItemViewModel model, Action completeAction);
    }
}
