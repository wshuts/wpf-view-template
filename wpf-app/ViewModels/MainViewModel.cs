using System.ComponentModel;

namespace wpf_app.ViewModels
{
    public class MainViewModel
    {
        public NavigationViewModel NavigationViewModel { get; set; }

        public void OnClosing(CancelEventArgs cancelEventArgs)
        {

        }

        public void Initialize()
        {
            NavigationViewModel = new NavigationViewModel();
            NavigationViewModel.Initialize();
        }
    }
}