using System;
using System.Threading.Tasks;
using NDC.Implementation.ViewModel;

namespace NDC.Interface.Repository
{
    public interface IHamburgerMenuRepository
    {
        Task HamburgerMenu(HamburgerMenuViewModel model, Action completeAction);
    }
}
