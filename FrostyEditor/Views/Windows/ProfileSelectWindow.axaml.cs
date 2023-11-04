using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System.Collections.Generic;

namespace FrostyEditor.Views.Windows;

public partial class ProfileSelectWindow : Window
{
    public ProfileSelectWindow()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        if (App.s_theme.XamlOverrides.ContainsKey("FrostyEditor/Views/Windows/ProfileSelectWindow"))
        {
            AvaloniaXamlLoader.Load(this);
            this.Content = AvaloniaRuntimeXamlLoader.Load(App.s_theme.XamlOverrides["FrostyEditor/Views/Windows/ProfileSelectWindow"]);
        }
        else
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}