using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CorePCL;

namespace NDC.Implementation.ViewModel.Base
{
    public class NDCBaseViewModel : BaseViewModel, INotifyPropertyChanged
    {
        protected bool SetProperty<T>([CallerMemberName]string propertyName = "",
            Action onChanged = null)
        {
            
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
