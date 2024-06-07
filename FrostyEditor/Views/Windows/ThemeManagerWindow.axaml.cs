using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using FrostyEditor.ViewModels.Windows;
using FrostyEditor.Views.Pages.Windows.ThemeManagerWindow;
using FrostyPlugin.Themes;
using FluentAvalonia.UI.Controls;
using System.Collections.Generic;

namespace FrostyEditor.Views.Windows;

public partial class ThemeManagerWindow : Window
{
    internal TabItem libraryTab = new TabItem { Content = new LibraryPage() };

    public ThemeManagerWindow()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
        ThemeManagerWindowViewModel viewModel = new ThemeManagerWindowViewModel();
        this.DataContext = viewModel;

        //TabControl tabControl = new TabControl { ItemsSource = new List<TabItem> { libraryTab } };
        //this.Content = tabControl;

        this.libraryContent.Content = new LibraryPage();

    }

    private void InitializeComponent()
    {
        //AvaloniaXamlLoader.Load(this);
        AvaloniaXamlLoader.Load(this);
    }
}
