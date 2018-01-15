using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CorePCL;
using NDC.Implementation.ViewModel;
using Xamarin.Forms;

namespace NCD.Interface.Repository
{
    public interface IMasterRepository
    {
        MasterModel DataSorce { get; set; }
        void SetRootView(Page rootView);
        Page GetRootView();
        Func<string, Dictionary<string, object>, BaseNetworkAccessEnum, Task> NetworkInterface { get; set; }
        Func<string, Dictionary<string, ParameterTypedValue>, BaseNetworkAccessEnum, Task> NetworkInterfaceWithTypedParameters { get; set; }

        //Navigation


        //Logic
        //debug
        void DumpJson<T>(string heading, T objectToDump);

        //Off-Line
    }
}
