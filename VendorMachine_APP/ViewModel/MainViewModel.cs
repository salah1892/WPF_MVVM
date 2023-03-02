using VendorMachine_APP.Common;
using VendorMachine_APP.Services;

namespace VendorMachine_APP.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private INavigationService _navigation;

        public INavigationService Navigation
        {
            get => _navigation;
            set
            {
                _navigation = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel(INavigationService navService)
        {
            Navigation = navService;
            Navigation.NavigateTo<AcceuilViewModel>();
        }
    }
}