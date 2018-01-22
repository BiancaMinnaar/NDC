using System.Threading.Tasks;
using NDC.Implementation.ViewModel;

namespace NDC.Interface.Service
{
    public interface IHomeViewService
    {
        Task HomeView(HomeViewViewModel model);
    }
}

