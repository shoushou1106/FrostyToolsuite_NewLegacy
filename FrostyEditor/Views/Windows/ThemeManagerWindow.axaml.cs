using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace FrostyEditor.Views.Windows;

public partial class ThemeManagerWindow : Window
{
    public ThemeManagerWindow()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
