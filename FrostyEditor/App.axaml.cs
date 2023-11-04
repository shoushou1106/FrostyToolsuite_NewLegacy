using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.ThemeManager;
using FrostyEditor.Utils;
using FrostyEditor.ViewModels;
using FrostyEditor.ViewModels.Windows;
using FrostyEditor.Views.Windows;
using FrostyPlugin.Themes;

namespace FrostyEditor;

public class App : Application
{
    public static string ConfigPath =
        $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/Frosty/editor_config.json";
    
    public static IFrostyTheme s_theme = new FrostyPlugin.Themes.DefaultTheme.FrostyTheme();
    public static IThemeManager s_themeManager = s_theme.ThemeManager;

    public override void Initialize()
    {
        s_themeManager.Initialize(this);
        
        Config.Load(ConfigPath);

        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        switch (ApplicationLifetime)
        {
            case IClassicDesktopStyleApplicationLifetime desktopLifetime:
            {
                ProfileSelectWindow selectWindow = new()
                {
                    DataContext = new ProfileSelectWindowViewModel()
                };

                desktopLifetime.MainWindow = selectWindow;

                break;
            }
        }

        base.OnFrameworkInitializationCompleted();
    }
}