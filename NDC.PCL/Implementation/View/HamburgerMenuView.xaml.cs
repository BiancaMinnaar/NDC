using System;
using Xamarin.Forms;
using System.Threading.Tasks;
using NDC.Implementation.ViewController;
using NDC.Implementation.ViewModel;

namespace NDC.Implementation.View
{
    public partial class HamburgerMenuView : ProjectBaseContentView<HamburgerMenuViewController, HamburgerMenuViewModel>
    {
        public HamburgerMenuView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = _ViewController.InputObject;
        }

        protected override void SetSVGCollection()
        {
        }

        public async Task On_HamburgerMenu_Event(object sender, EventArgs e)
        {
            await _ViewController.HamburgerMenu();
        }
    }
}


