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
    /*

    Full example: 

    public class ThemePlugin : IFrostyTheme
    {
        public IThemeManager ThemeManager { get => new ExampleThemeManager(); }

        public string Name { get => "Example Name"; }

        public string? Author { get; }
    or
        public string? Author { get => "Example Author"; }

        public object? Icon { get; }
    or
        public object? Icon { get; }

        public List<object>? Screenshots { get; }
    or
        public List<object>? Screenshots { get => TODO; }

        public string? Description { get; }
    or
        public string? Description { get => "Example Description"; }

        public List<string>? Links { get; }
    or
        public List<string>? Links { get => new() { "https://github.com/CadeEvs/FrostyToolsuite", "https://frostytoolsuite.com/", "https://discord.gg/VVVVVVVV" }; }

        public bool SupportAllPlatforms { get => true; }

        public List<OSPlatform>? SupportPlatforms { get; }
    or
        public List<OSPlatform>? SupportPlatforms { get => new() { OSPlatform.Windows, OSPlatform.Linux, OSPlatform.EXAMPLE }; }
    }

    */

    IThemeManager ThemeManager { get; }
    string Name { get; }
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
