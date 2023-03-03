using System;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using VendorMachine_APP.Common;
using VendorMachine_APP.Services;
using VendorMachine_APP.View;
using VendorMachine_APP.ViewModel;

namespace VendorMachine_APP
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;

        public App()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<MainWindow>(provider => new MainWindow
            {
                
                DataContext = provider.GetRequiredService<MainViewModel>(),
                main = new Acceuil()
                
            });

            services.AddSingleton<MainViewModel>();
            services.AddSingleton<AbonneeViewModel>();
            services.AddSingleton<AcceuilViewModel>();
            services.AddSingleton<TicketViewModel>();
            services.AddSingleton<CheckAbonneeViewModel>();
            services.AddSingleton<INavigationService, NavigationService>();

            services.AddSingleton<Func<Type, ViewModelBase>>(serviceProvider =>
                viewModelType => (ViewModelBase)serviceProvider.GetRequiredService(viewModelType));

            _serviceProvider = services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
            base.OnStartup(e);
        }
    }
}