using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace FrostyEditor.Views.Pages.Windows.ThemeManagerWindow;

public partial class LibraryPage : UserControl
{
    public LibraryPage()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
