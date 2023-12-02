using CommunityToolkit.Mvvm.ComponentModel;
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
        public string Name { get; set; }

        public string Version { get; set; }

        public string? Author { get; set; }

        public object? Icon { get; set; }

        public List<object>? Screenshots { get; set; }

        public string? Description { get; set; }

        public List<string>? Links { get; set; }

        public ThemeItem(IFrostyTheme frostyTheme)
        {
            Name = frostyTheme.Name;
            Version = frostyTheme.Version;
            Author = frostyTheme.Author;
            Description = frostyTheme.Description;
        }
    }

    public ObservableCollection<ThemeItem> ThemeItems { get; set; } = new();

    public ThemeManagerWindowViewModel()
    {
        foreach (IFrostyTheme frostyTheme in ThemeLibrary.FrostyThemes.Values)
        {
            ThemeItems = new();
            ThemeItems.Add(new ThemeItem(frostyTheme));
        }
    }
}