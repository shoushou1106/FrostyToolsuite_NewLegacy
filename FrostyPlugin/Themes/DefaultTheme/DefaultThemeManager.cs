using System;
using Avalonia;
using Avalonia.Markup.Xaml.Styling;
using Avalonia.Styling;
using Avalonia.ThemeManager;
using Avalonia.Themes.Fluent;
using FrostyPlugin.Themes.DefaultTheme.Styles;

namespace FrostyPlugin.Themes.DefaultTheme;

public class DefaultThemeManager : IThemeManager
{
    private static readonly Uri s_baseUri = new("avares://FrostyPlugin/Themes/DefaultTheme/");

    private static readonly FluentTheme s_theme = new();

    private static readonly DockTheme s_dock = new();

    private static readonly TreeDataGridTheme s_treeDataGrid = new();

    private static readonly Avalonia.Styling.Styles s_dark = new()
    {
        new StyleInclude(s_baseUri)
        {
            Source = new Uri("avares://FrostyPlugin/Themes/DefaultTheme/Styles/Dark.axaml")
        }
    };

    private static readonly Avalonia.Styling.Styles s_light = new()
    {
        new StyleInclude(s_baseUri)
        {
            Source = new Uri("avares://FrostyPlugin/Themes/DefaultTheme/Styles/Light.axaml")
        }
    };

    public void Switch(int index)
    {
        if (Application.Current is null)
        {
            return;
        }

        switch (index)
        {
            // Light
            case 0:
            {
                Application.Current.RequestedThemeVariant = ThemeVariant.Light;
                Application.Current.Styles[0] = s_theme;
                Application.Current.Styles[1] = s_dock;
                Application.Current.Styles[2] = s_treeDataGrid;
                Application.Current.Styles[3] = s_light;
                break;
            }
            // Dark
            case 1:
            {
                Application.Current.RequestedThemeVariant = ThemeVariant.Dark;
                Application.Current.Styles[0] = s_theme;
                Application.Current.Styles[1] = s_dock;
                Application.Current.Styles[2] = s_treeDataGrid;
                Application.Current.Styles[3] = s_dark;
                break;
            }
        }
    }

    public void Initialize(Application application)
    {
        application.RequestedThemeVariant = ThemeVariant.Dark;
        application.Styles.Insert(0, s_theme);
        application.Styles.Insert(1, s_dock);
        application.Styles.Insert(2, s_treeDataGrid);
        application.Styles.Insert(3, s_dark);
    }
}
