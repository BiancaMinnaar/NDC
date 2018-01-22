using System;
using System.Threading.Tasks;
using NDC.Interface.Service;
using NDC.Interface.Repository;
using NDC.Implementation.ViewModel;
using NDC.Interface.Reposetory;

namespace NDC.Implementation.Repository
{
    public class LoginRepository : ProjectBaseRepository, ILoginRepository
    {
        IAuthenticateService service;

        public LoginRepository(IMasterRepository masterRepository, IAuthenticateService authenticateService)
            : base(masterRepository)
        {
            service = authenticateService;
        }

        public async Task Login(LoginViewModel model, Action completeAction)
		{
            await service.LoginUser(model);
            completeAction();
 		}
    }
}
