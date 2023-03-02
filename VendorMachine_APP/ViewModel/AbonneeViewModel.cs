using System.Windows.Input;
using System.Windows.Navigation;
using VendorMachine_APP.Common;
using VendorMachine_APP.Services;
using VendorMachine_APP.View;

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

        public RelayCommand NavigateToTicketViewFromAbonneeView { get; set; }

        public AbonneeViewModel(INavigationService navigationService)
        {
            Navigation = navigationService;
            NavigateToTicketViewFromAbonneeView = new RelayCommand(o => { Navigation.NavigateTo<TicketViewModel>(); }, (o => true));
        }
    }
}