using System;
using NDC.Implementation.ViewModel.Base;

namespace NDC.PCL.Implementation.ViewModel
{
    public class LoginViewModel : NDCBaseViewModel
    {
        public string UserName { get; set; }
        private string _Password;
        public string Password
        {
            get
            {
                string encrypt = Encrypt(_Password);
                return encrypt;
            }
            set { _Password = value; }
        }

        public DateTime DateLastChanged { get; set; }
    }
}
