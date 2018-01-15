using NDC.PCL.Implementation.ViewModel;

namespace NDC.Implementation.ViewModel
{
    public sealed class MasterModel
    {
        public bool Authenticated { get; set; }
        public UserViewModel LoggedInUser { get; set; }
    }
}
