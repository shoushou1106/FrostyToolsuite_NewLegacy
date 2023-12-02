using Avalonia.ThemeManager;
using System.Runtime.InteropServices;

namespace FrostyPlugin.Themes.DefaultTheme;

public class FrostyTheme : IFrostyTheme
{
    public IThemeManager ThemeManager { get => new ThemeManager(); }

    public string Name { get => "Default Theme"; }

    public string Version { get => "1.0.0"; }

    public string? Author { get => "Frosty"; }

    public object? Icon { get; }

    public List<object>? Screenshots { get; }

    public string? Description { get => "Default Theme for Frosty"; }

    public List<string>? Links { get; }

    public List<OSPlatform>? SupportPlatforms { get; }
    public string SupportFrosty { get => "*"; }
    public string SupportFrostyVersion { get => "*"; }

    public Dictionary<string, string> XamlOverrides { get => XamlOverride.GetXamlOverride(); }
}
