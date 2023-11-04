using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FrostyPlugin.Themes;

public static class ThemeLibrary
{
    public static bool IsInitialized { get; private set; }

    public static Dictionary<string, IFrostyTheme> FrostyThemes => s_frostyThemes;
    public static IFrostyTheme FrostyTheme { get => s_frostyTheme ?? s_defaultFrostyTheme; set => s_frostyTheme = value; }
    public static IFrostyTheme DefaultFrostyTheme => s_defaultFrostyTheme;

    public static bool HasSelectedTheme => s_frostyTheme is not null;

    private static Dictionary<string, IFrostyTheme> s_frostyThemes = new();
    private static IFrostyTheme? s_frostyTheme;
    private static IFrostyTheme s_defaultFrostyTheme = new FrostyPlugin.Themes.DefaultTheme.FrostyTheme();

    public static void Initialize(string Path)
    {
        s_frostyThemes = new();
        
        foreach (var themePluginPath in Directory.GetFiles(Path))
        {
            try
            {
                Assembly themePluginAssembly = Assembly.LoadFile(themePluginPath);
                Type? themePlugin = themePluginAssembly.GetType(themePluginAssembly.GetName().Name + ".FrostyTheme");
                if (themePlugin != null)
                {
                    if (typeof(IFrostyTheme).IsAssignableFrom(themePlugin))
                    {
                        IFrostyTheme? result = Activator.CreateInstance(themePlugin) as IFrostyTheme;
                        if (result != null)
                        {
                            s_frostyThemes.Add(System.IO.Path.GetFileNameWithoutExtension(themePluginPath), result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // TODO: Message box “Failed to read Theme {themePluginPath} or {ex.Message}”
            }
        }
    }
}
