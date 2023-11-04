using System;
using System.Collections.Generic;
using System.IO;
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

    public override void Initialize()
    {
        Config.Load(ConfigPath);

        if (!Config.Contains("ThemePath"))
        {
            Config.Add("ThemePath", Path.GetFullPath($"{Directory.GetCurrentDirectory()}\\Themes\\"));
            Config.Save(ConfigPath);
        }
        string themePath = Config.Get("ThemePath")?.ToString() ?? Path.GetFullPath($"{Directory.GetCurrentDirectory()}\\Themes\\");
        if (!Path.Exists(themePath))
        {
            Directory.CreateDirectory(themePath);
        }
        ThemeLibrary.Initialize(themePath);

        ThemeLibrary.FrostyTheme = ThemeLibrary.FrostyThemes["ExampleThemePlugin"];
        ThemeLibrary.FrostyTheme.ThemeManager.Initialize(this);
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