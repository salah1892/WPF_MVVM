using VendorMachine_APP.Common;
using VendorMachine_APP.Services;

namespace VendorMachine_APP.ViewModel
{
    public class AbonneeViewModel:ViewModelBase
    {
        public INavigationService _navigation;

        public INavigationService Navigation
        {
            get => _navigation;
            set
            {
                _navigation = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand NavigateToCheckAbonneeViewFromAbonneeView { get; set; }

        public AbonneeViewModel(INavigationService navigationService)
        {
            Navigation = navigationService;
            NavigateToCheckAbonneeViewFromAbonneeView = new RelayCommand(o => { Navigation.NavigateTo<CheckAbonneeViewModel>(); }, (o => true));
        }
    }
}