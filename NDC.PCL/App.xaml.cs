using System;
using NDC.Implementation.Repository;
using NDC.Implementation.View.Login;
using NDC.Implementation.View;
using Xamarin.Forms;

namespace NDC
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var _MasterRepo = MasterRepository.MasterRepo;
            _MasterRepo.SetRootView(new NavigationPage(new HomeViewView()));
            //_MasterRepo.SetRootView(new NavigationPage(new TestHarnesView()));
            MainPage = _MasterRepo.GetRootView();
        }
    }
}
