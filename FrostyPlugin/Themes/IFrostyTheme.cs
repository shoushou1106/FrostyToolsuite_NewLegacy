using Avalonia.ThemeManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FrostyPlugin.Themes;

public interface IFrostyTheme
{
    IThemeManager ThemeManager { get; }

    string Name { get; }

    string Version { get; }

    string? Author { get; }

    object? Icon { get; }

    List<object>? Screenshots { get; }

    string? Description { get; }

    List<string>? Links { get; }

    /// <summary>
    /// Set to null means support all platforms
    /// </summary>
    List<OSPlatform>? SupportPlatforms { get; }

    Dictionary<string, string> XamlOverrides { get; }
}
