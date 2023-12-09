using Avalonia.Controls;
using FrostyEditor.ViewModels;

namespace FrostyEditor.Views;

public partial class MenuView : UserControl
{
    public MenuView()
    {
        InitializeComponent();
        MenuViewModel viewModel = new MenuViewModel();
        this.DataContext = viewModel;
    }
}
