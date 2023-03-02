using VendorMachine_APP.Common;
using VendorMachine_APP.Services;

namespace VendorMachine_APP.ViewModel;

public class AcceuilViewModel : ViewModelBase
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

    public RelayCommand NavigateToAbonneeView { get; set; }
    public RelayCommand NavigateToTicketView { get; set; }

    public AcceuilViewModel(INavigationService navService)
    {
        Navigation = navService;
        NavigateToAbonneeView = new RelayCommand(o => { Navigation.NavigateTo<AbonneeViewModel>(); }, o => true);
        NavigateToTicketView = new RelayCommand(o => { Navigation.NavigateTo<TicketViewModel>(); }, o => true);
    }
}