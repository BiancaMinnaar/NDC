using System.Threading.Tasks;
using NDC.Implementation.ViewModel;

namespace NDC.Interface.Service
{
    public interface IHamburgerMenuService
    {
        Task HamburgerMenu(HamburgerMenuViewModel model);
    }
}

