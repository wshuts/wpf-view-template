using System.ComponentModel;
using System.Windows;
using wpf_app.ViewModels;

namespace wpf_app.Views
{
  public partial class MainWindow : Window
  {
    private MainViewModel _viewModel;

    public MainWindow(MainViewModel viewModel)
    {
      InitializeComponent();
      _viewModel = viewModel;
      DataContext = _viewModel;
    }

    protected override void OnClosing(CancelEventArgs e)
    {
      base.OnClosing(e);
      _viewModel.OnClosing(e);
    }
  }
}
