﻿using System.Threading.Tasks;
using NDC.Implementation.ViewModel;

namespace NDC.Interface.Service
{
    public interface IAuthenticateService
    {
        Task LoginUser(LoginViewModel model);
    }
}
