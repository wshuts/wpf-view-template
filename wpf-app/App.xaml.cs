using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using wpf_app.ViewModels;
using wpf_app.Views;

namespace wpf_app
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private MainViewModel _mainViewModel;

        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            _mainViewModel = new MainViewModel();
            _mainViewModel.Initialize();
            MainWindow = new MainWindow(_mainViewModel);
            MainWindow.Show();
        }
    }
}
