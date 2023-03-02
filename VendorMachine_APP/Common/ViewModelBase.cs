using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VendorMachine_APP.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        // public event PropertyChangedEventHandler PropertyChanged;

        // // [NotifyPropertyChangedInvocator]
        // // protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        // // {
        // //     PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        // // }
        // protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        // {
        //     PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        // }
        // // protected virtual void OnPropertyChanged()
        // // {
        // //     this.PropertyChanged?.Invoke(this);
        // // }
    }
}