using System;
using System.Threading.Tasks;
using NDC.Implementation.ViewModel;

namespace NDC.Interface.Repository
{
    public interface IHomeViewRepository
    {
        Task HomeView(HomeViewViewModel model, Action completeAction);
    }
}
