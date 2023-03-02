using System.Windows.Input;
using VendorMachine_APP.Common;
using VendorMachine_APP.Services;

namespace VendorMachine_APP.ViewModel
{
    public class TicketViewModel : ViewModelBase
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

        public RelayCommand NavigateToAbonneeViewFromTicketView { get; }

        public TicketViewModel(INavigationService navService)
        {
            Navigation = navService;
            NavigateToAbonneeViewFromTicketView = new RelayCommand(o => { Navigation.NavigateTo<AbonneeViewModel>(); }, (o => true));
        }
    }
}