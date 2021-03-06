﻿using System;
using Xamarin.Forms;
using System.Threading.Tasks;
using NDC.Implementation.ViewController;
using NDC.Implementation.ViewModel;

namespace NDC.Implementation.View.Login
{
    public partial class LoginView : ProjectBaseContentPage<LoginViewController, LoginViewModel>
    {
		public LoginView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = _ViewController.InputObject;
        }

        protected override void SetSVGCollection()
        {
        }

        public async void On_Login_Click(object sender, EventArgs e)
        {
            await _ViewController.Login();
        }
    }
}
