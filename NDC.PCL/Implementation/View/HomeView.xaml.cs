using System;
using Xamarin.Forms;
using System.Threading.Tasks;
using NDC.Implementation.ViewController;
using NDC.Implementation.ViewModel;

namespace NDC.Implementation.View
{
    public partial class HomeViewView : ProjectBaseContentPage<HomeViewViewController, HomeViewViewModel>
    {
        public HomeViewView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = _ViewController.InputObject;
        }

        protected override void SetSVGCollection()
        {
        }

        public async Task On_HomeView_Event(object sender, EventArgs e)
        {
            await _ViewController.HomeView();
        }
    }
}


