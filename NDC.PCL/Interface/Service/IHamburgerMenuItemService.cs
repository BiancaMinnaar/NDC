using System.Threading.Tasks;
using NDC.Implementation.ViewModel;

namespace NDC.Interface.Service
{
    public interface IHamburgerMenuItemService
    {
        Task HamburgerMenuItem(HamburgerMenuItemViewModel model);
    }
}

