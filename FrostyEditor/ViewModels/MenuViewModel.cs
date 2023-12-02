using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FrostyEditor.Views.Windows;

namespace FrostyEditor.ViewModels;

public partial class MenuViewModel : ObservableObject
{
    public MenuViewModel()
    {

    }

    [RelayCommand]
    private void OpenThemeManager()
    {
        ThemeManagerWindow themeManagerWindow = new ThemeManagerWindow();
        themeManagerWindow.Show();
    }
}