using Avalonia.ThemeManager;
using System.Runtime.InteropServices;

namespace FrostyPlugin.Themes.DefaultTheme;

public class FrostyTheme : IFrostyTheme
{
    public IThemeManager ThemeManager { get => new DefaultThemeManager(); }

    public string Name { get => "Default Theme"; }

    public string? Author { get => "Frosty"; }

    public object? Icon { get; }

    public List<object>? Screenshots { get; }

    public string? Description { get => "Default Theme for Frosty"; }

    public List<string>? Links { get; }

    public bool SupportAllPlatforms { get => true; }

    public List<OSPlatform>? SupportPlatforms { get; }

    public Dictionary<string, string> XamlOverrides { get => XamlOverride.GetXamlOverride(); }
}
