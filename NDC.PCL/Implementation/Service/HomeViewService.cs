using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CorePCL;
using NDC.Implementation.ViewModel;
using NDC.Interface.Service;

namespace NDC.Implementation.Service
{
    public class HomeViewService : BaseService, IHomeViewService
    {
        public HomeViewService(Func<string, Dictionary<string, object>, BaseNetworkAccessEnum, Task> networkInterface)
            :base(networkInterface)
        {
        }

        public async Task HomeView(HomeViewViewModel model)
        {
            string requestURL = "/path/{Parameter}";
            var httpMethod = BaseNetworkAccessEnum.Put;
            var parameters = new Dictionary<string, object>()
            {
                //{"Parameter", model.Property},
            };
            await _NetworkInterface(requestURL, parameters, httpMethod);
        }
    }
}
