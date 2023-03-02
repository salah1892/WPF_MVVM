using System.Windows.Controls;
using VendorMachine_APP.ViewModel;

namespace VendorMachine_APP.Services;

public interface INavigationService
{
    ViewModelBase CurrentView { get; }
    void NavigateTo<T>() where T : ViewModelBase;
}