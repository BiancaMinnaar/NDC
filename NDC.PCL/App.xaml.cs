using System;
using NDC.Implementation.View.Login;
using Xamarin.Forms;

namespace NDC
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginView();
        }
    }
}
