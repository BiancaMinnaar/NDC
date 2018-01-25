using System.Threading.Tasks;
using NDC.Base;
using NDC.Implementation.Repository;
using NDC.Implementation.Service;
using NDC.Implementation.ViewModel;
using NDC.Interface.Repository;
using NDC.Interface.Service;
using NDC.Interface.ViewController;

namespace NDC.Implementation.ViewController
{
    public class HamburgerMenuViewController : ProjectBaseViewController<HamburgerMenuViewModel>, IHamburgerMenuViewController
    {
        IHamburgerMenuRepository _Reposetory;
        IHamburgerMenuService _Service;

        public override void SetRepositories()
        {
            _MasterRepo.NetworkInterface = (U, P, A) => ExecuteQueryWithObjectAndNetworkAccessAsync(U, P, A);
            _MasterRepo.NetworkInterfaceWithTypedParameters = (U, P, A) => ExecuteQueryWithTypedParametersAndNetworkAccessAsync(U, P, A);
            _Service = new HamburgerMenuService(_MasterRepo.NetworkInterface);
            _Reposetory = new HamburgerMenuRepository(_MasterRepo, _Service);
        }

        public async Task HamburgerMenu()
        {
            
        }
    }
}