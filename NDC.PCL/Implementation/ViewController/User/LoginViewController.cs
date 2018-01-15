using System.Threading.Tasks;
using NDC.Interface.Service;
using NDC.Base;
using NDC.Implementation.ViewModel;
using NDC.Interface.Reposetory;
using NDC.Interface.ViewController;
using NDC.PCL.Implementation.ViewModel;
using NDC.Implementation.Service;
using NDC.Implementation.Repository;

namespace NDC.Implementation.ViewController
{
    public class LoginViewController : ProjectBaseViewController<LoginViewModel>, ILoginViewController
    {
        private ILoginRepository _Reposetory;
        IAuthenticateService _AuthService;

        public override void SetRepositories()
        {
            _MasterRepo.NetworkInterface = (U, P, A) => ExecuteQueryWithObjectAndNetworkAccessAsync(U, P, A);
            _MasterRepo.NetworkInterfaceWithTypedParameters = (U, P, A) => ExecuteQueryWithTypedParametersAndNetworkAccessAsync(U, P, A);
			_AuthService = new AuthenticateService(_MasterRepo.NetworkInterface);
            _Reposetory = new LoginRepository(_MasterRepo, _AuthService);
        }

        public async Task Login()
        {
            
        }
    }
}