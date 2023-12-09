using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using FrostyEditor.ViewModels.Windows;
using FrostyEditor.Views.Pages.Windows.ThemeManagerWindow;
using FrostyPlugin.Themes;

namespace FrostyEditor.Views.Windows;

public partial class ThemeManagerWindow : Window
{
    public ThemeManagerWindow()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
        ThemeManagerWindowViewModel viewModel = new ThemeManagerWindowViewModel();
        this.DataContext = viewModel;
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
