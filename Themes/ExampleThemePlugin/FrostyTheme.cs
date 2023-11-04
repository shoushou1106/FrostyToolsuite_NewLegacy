using Avalonia.ThemeManager;
using FrostyPlugin.Themes;
using System.Runtime.InteropServices;

namespace ExampleThemePlugin;

public class FrostyTheme : IFrostyTheme
{
    public IThemeManager ThemeManager { get => new ThemeManager(); }

    public string Name { get => "Example Theme"; }

    public string? Author { get => "shoushou1106"; }

    public object? Icon { get; }

    public List<object>? Screenshots { get; }

    public string? Description { get => "Example"; }

    public List<string>? Links { get; }

    public List<OSPlatform>? SupportPlatforms { get; }

    public Dictionary<string, string> XamlOverrides { get => XamlOverride.GetXamlOverride(); }
}
