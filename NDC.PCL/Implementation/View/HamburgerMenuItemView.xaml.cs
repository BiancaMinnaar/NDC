using System;
using Xamarin.Forms;
using System.Threading.Tasks;
using NDC.Implementation.ViewController;
using NDC.Implementation.ViewModel;

namespace NDC.Implementation.View
{
    public partial class HamburgerMenuItemView : ProjectBaseContentView<HamburgerMenuItemViewController, HamburgerMenuItemViewModel>
    {
        public HamburgerMenuItemView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = _ViewController.InputObject;
        }

        protected override void SetSVGCollection()
        {
        }

        public async Task On_HamburgerMenuItem_Event(object sender, EventArgs e)
        {
            await _ViewController.HamburgerMenuItem();
        }
    }
}


