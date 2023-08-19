using Microsoft.UI.Xaml.Controls;

using TestCsWin32.ViewModels;

namespace TestCsWin32.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
