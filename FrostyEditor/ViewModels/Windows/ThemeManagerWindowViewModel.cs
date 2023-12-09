using Avalonia.ThemeManager;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FrostyEditor.Views.Windows;
using FrostyPlugin.Themes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FrostyEditor.ViewModels.Windows;

public partial class ThemeManagerWindowViewModel : ObservableObject
{
    public class ThemeItem
    {
        public IFrostyTheme FrostyTheme { get; set; }

        public string Name { get; set; }

        public string Version { get; set; }

        public string? Author { get; set; }

        public object? Icon { get; set; }

        public List<object>? Screenshots { get; set; }

        public string? Description { get; set; }

        public List<string>? Links { get; set; }

        public ThemeItem(IFrostyTheme frostyTheme)
        {
            FrostyTheme = frostyTheme;
            Name = frostyTheme.Name;
            Version = frostyTheme.Version;
            Author = frostyTheme.Author;
            Description = frostyTheme.Description;
        }
    }

    public ObservableCollection<ThemeItem> ThemeItems { get; set; } = new();

    public ThemeManagerWindowViewModel()
    {
        ThemeItems = new();
        foreach (IFrostyTheme frostyTheme in ThemeLibrary.FrostyThemes.Values)
        {
            ThemeItems.Add(new ThemeItem(frostyTheme));
        }

#if DEBUG
        ThemeItems.Add(new ThemeItem(ThemeLibrary.DefaultFrostyTheme));
        ThemeItems.Add(new ThemeItem(new PlaceholderTheme1()));
        ThemeItems.Add(new ThemeItem(new PlaceholderTheme2()));
        ThemeItems.Add(new ThemeItem(new PlaceholderTheme3()));
#endif
    }


    [RelayCommand]
    private void OpenThemeDetails(IFrostyTheme frostyTheme)
    {
    }

    #region - Debug ThemeItems -
#if DEBUG
    private class PlaceholderTheme1 : IFrostyTheme
    {
        public IThemeManager ThemeManager { get => new SimpleThemeManager(); }

        public string Name { get => "Placeholder Theme 1"; }

        public string Version { get => "1.0.0"; }

        public string? Author { get => "Frosty Debug"; }

        public object? Icon { get; }

        public List<object>? Screenshots { get; }

        public string? Description { get => "Debug Theme 1" + Environment.NewLine + "DO NOT APPLY THIS"; }

        public List<string>? Links { get; }

        public List<OSPlatform>? SupportPlatforms { get; }
        public string SupportFrosty { get => "*"; }
        public string SupportFrostyVersion { get => "*"; }

        public Dictionary<string, string> XamlOverrides { get => new(); }
    }

    private class PlaceholderTheme2 : IFrostyTheme
    {
        public IThemeManager ThemeManager { get => new SimpleThemeManager(); }

        public string Name { get => "Placeholder Theme 2"; }

        public string Version { get => "1.0.0"; }

        public string? Author { get => "Frosty Debug"; }

        public object? Icon { get; }

        public List<object>? Screenshots { get; }

        public string? Description { get => "Debug Theme 2" + Environment.NewLine + "DO NOT APPLY THIS"; }

        public List<string>? Links { get; }

        public List<OSPlatform>? SupportPlatforms { get; }
        public string SupportFrosty { get => "*"; }
        public string SupportFrostyVersion { get => "*"; }

        public Dictionary<string, string> XamlOverrides { get => new(); }
    }

    private class PlaceholderTheme3 : IFrostyTheme
    {
        public IThemeManager ThemeManager { get => new SimpleThemeManager(); }

        public string Name { get => "Placeholder Theme 3"; }

        public string Version { get => "1.0.0"; }

        public string? Author { get => "Frosty Debug"; }

        public object? Icon { get; }

        public List<object>? Screenshots { get; }

        public string? Description { get => "Debug Theme 3" + Environment.NewLine + "DO NOT APPLY THIS"; }

        public List<string>? Links { get; }

        public List<OSPlatform>? SupportPlatforms { get; }
        public string SupportFrosty { get => "*"; }
        public string SupportFrostyVersion { get => "*"; }

        public Dictionary<string, string> XamlOverrides { get => new(); }
    }
#endif
    #endregion
}