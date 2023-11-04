using System;
using Avalonia;
using Avalonia.Markup.Xaml.Styling;
using Avalonia.Styling;
using Avalonia.ThemeManager;
using Avalonia.Themes.Fluent;
using FrostyPlugin.Themes.DefaultTheme.Styles;

namespace FrostyPlugin.Themes.DefaultTheme;

public static class XamlOverride
{
    public static Dictionary<string, string> GetXamlOverride()
    {
        Dictionary<string, string> xamlOverride = new()
        {
        };

        return xamlOverride;
    }
}
