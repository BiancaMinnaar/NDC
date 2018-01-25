using System;
using System.Windows.Input;
using NDC.Base;

namespace NDC.Implementation.ViewModel
{
    public class HamburgerMenuItemViewModel : ProjectBaseViewModel
    {
        public string ListIndex { get; set; }
        public string IndexIndicator { get; set; }
        public string Description { get; set; }

        ICommand menuItemClicked;
        public ICommand MenuItemClickedCommand
        {
            get { return menuItemClicked; }
        }
    }
}