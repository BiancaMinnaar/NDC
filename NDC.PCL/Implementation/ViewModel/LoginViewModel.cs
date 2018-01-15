using System;
using NDC.Base;

namespace NDC.Implementation.ViewModel
{
    public class LoginViewModel : ProjectBaseViewModel
    {
        public string UserName { get; set; }
        //private string _Password;
        //public string Password 
        //{ 
        //    get 
        //    { 
        //        string encrypt = Encrypt(_Password);
        //        return encrypt;
        //    } 
        //    set { _Password = value; }
        //}
        public string Password { get; set; }

        public DateTime DateLastChanged { get; set; }
    }
}
