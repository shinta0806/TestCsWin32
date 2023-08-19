using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using TestCsWin32.ViewModels;
using Windows.Win32;
using Windows.Win32.Foundation;

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

    private async void Button01_Click(Object _1, RoutedEventArgs _2)
    {
        HWND hwnd = PInvoke.GetForegroundWindow();
        ContentDialog contentDialog = new()
        {
            Title = "情報",
            Content = "ハンドル：" + hwnd.Value.ToString("X16"),
            PrimaryButtonText = "OK",
            XamlRoot = App.MainWindow.Content.XamlRoot,
        };
        await contentDialog.ShowAsync();
    }
}
