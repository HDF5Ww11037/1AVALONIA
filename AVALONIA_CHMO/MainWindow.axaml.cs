using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AVALONIA_CHMO;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        if (Zet.IsVisible)
        {
            Zet.IsVisible = false;
        }
        else
        {
            Zet.IsVisible = true;
        }
    }

    private void Button_OnClick_Close (object? sender, RoutedEventArgs e)
    {
        Close();
    }
}