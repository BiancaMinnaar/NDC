using System;
using NDC.PCL.Implementation;
using Xamarin.Forms;

namespace NDC
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Login();
        }
    }
}
