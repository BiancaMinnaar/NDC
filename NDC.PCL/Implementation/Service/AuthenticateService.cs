﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CorePCL;
using NDC.Implementation.ViewModel;
using NDC.Interface.Service;

namespace NDC.Implementation.Service
{
    public class AuthenticateService : BaseService, IAuthenticateService
    {
        public AuthenticateService(Func<string, Dictionary<string, object>, BaseNetworkAccessEnum, Task> networkInterface)
            :base(networkInterface)
        {
        }

        public async Task LoginUser(LoginViewModel model)
        {
			string requestURL = "/Authentication/Login/{UserName}/{Password}/{Basic}";
			var httpMethod = BaseNetworkAccessEnum.Put;
			var parameters = new Dictionary<string, object>()
			{
				{"UserName", model.UserName},
				{"Password", model.Password},
				{"Basic", "true"}
			};
			await _NetworkInterface(requestURL, parameters, httpMethod);
        }
    }
}
