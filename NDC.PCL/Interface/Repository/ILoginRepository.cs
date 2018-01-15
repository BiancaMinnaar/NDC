using System;
using System.Threading.Tasks;
using NDC.Implementation.ViewModel;

namespace NDC.Interface.Reposetory
{
    public interface ILoginRepository
    {
        Task Login(LoginViewModel model, Action completeAction);
    }
}
