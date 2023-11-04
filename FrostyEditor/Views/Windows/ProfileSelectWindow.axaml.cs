using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using FrostyPlugin.Themes;
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
        if (ThemeLibrary.FrostyTheme.XamlOverrides.ContainsKey("FrostyEditor/Views/Windows/ProfileSelectWindow"))
        {
            AvaloniaXamlLoader.Load(this);
            this.Content = AvaloniaRuntimeXamlLoader.Load(ThemeLibrary.FrostyTheme.XamlOverrides["FrostyEditor/Views/Windows/ProfileSelectWindow"]);
        }
        else
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}