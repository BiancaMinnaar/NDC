﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Acr.UserDialogs;
using CorePCL;
using NDC.Interface.Repository;
using NDC.Implementation.ViewModel;
using Newtonsoft.Json;
using Xamarin.Forms;
using NDC.Implementation.View;

namespace NDC.Implementation.Repository
{
    public class MasterRepository : ProjectBaseRepository, IMasterRepository
    {
        private static MasterRepository _Reposetory = new MasterRepository();
        private static readonly object syncronisationLock = new object();
        public MasterModel DataSorce { get; set; }
        private INavigation _Navigation;
        private Page _RootView;
        public Func<string, Dictionary<string, object>, BaseNetworkAccessEnum, Task> NetworkInterface { get; set; }
        public Func<string, Dictionary<string, ParameterTypedValue>, BaseNetworkAccessEnum, Task> NetworkInterfaceWithTypedParameters { get; set; }

        MasterRepository()
            : base(null)
        {
            DataSorce = new MasterModel();
        }

        public static MasterRepository MasterRepo
        {
            get { return _Reposetory; }
        }

        public void SetRootView(Page rootView)
        {
            _RootView = rootView;
            _Navigation = rootView.Navigation;
            
        }

        public Page GetRootView()
        {
            return _RootView;
        }

		public void PushLogOut()
        {
            DataSorce.Authenticated = false;
            _Navigation.PopToRootAsync();
        }

        public void PopView()
        {
            _Navigation.PopAsync();
        }

        public void PushHomeView()
        {
            _Navigation.PushAsync(new HomeViewView());
        }

        public void PopModal()
        {
            _Navigation.PopModalAsync();
        }

        public void ShowLoading()
        {
            UserDialogs.Instance.ShowLoading();
        }

        public void HideLoading()
        {
            UserDialogs.Instance.HideLoading();
        }

        public void DumpJson<T>(string heading, T objectToDump)
        {
            Debug.WriteLine(heading);
            Debug.WriteLine(JsonConvert.SerializeObject(objectToDump));
        }
    }
}
