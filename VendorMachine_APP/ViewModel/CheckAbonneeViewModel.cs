using VendorMachine_APP.Common;
using VendorMachine_APP.Services;

namespace VendorMachine_APP.ViewModel;

public class CheckAbonneeViewModel:ViewModelBase
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

    public RelayCommand NavigateToMainViewFromCheckAbonneeView { get; set; }

    public CheckAbonneeViewModel(INavigationService navigationService)
    {
        Navigation = navigationService;
        NavigateToMainViewFromCheckAbonneeView = new RelayCommand(o => { Navigation.NavigateTo<AcceuilViewModel>(); }, (o => true));
    }
}