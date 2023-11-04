using System;
using Avalonia;
using Avalonia.Markup.Xaml.Styling;
using Avalonia.Styling;
using Avalonia.ThemeManager;
using Avalonia.Themes.Fluent;
using FrostyPlugin.Themes.DefaultTheme.Styles;

namespace FrostyPlugin.Themes.DefaultTheme;

public static class XamlOverride
{
    public static Dictionary<string, string> GetXamlOverride()
    {
        Dictionary<string, string> xamlOverride = new()
        {
            {
                "FrostyEditor/Views/Windows/ProfileSelectWindow",
@"
<Grid xmlns='https://github.com/avaloniaui' Background='Transparent'>
    <Grid.RowDefinitions>
        <RowDefinition Height='*'/>
        <RowDefinition Height='Auto'/>
    </Grid.RowDefinitions>
        
    <Grid Grid.Row='0'>
        <ListBox ItemsSource='{Binding Profiles}' SelectedItem='{Binding SelectedProfile}'>
            <ListBox.ItemTemplate>
                <DataTemplate>
                    <StackPanel>
                        <TextBlock Text='{Binding Name}'/>
                        <TextBlock Text='{Binding Path}'/>
                    </StackPanel>
                </DataTemplate>
            </ListBox.ItemTemplate>
        </ListBox>
    </Grid>
        
    <Grid Grid.Row='1'>
        <StackPanel HorizontalAlignment='Right' Orientation='Horizontal'>
            <Button Content='{StaticResource ID_PROFILE_ADD}' Command='{Binding AddProfileCommand}'/>
            <Button Content='{StaticResource ID_PROFILE_SELECT}' Command='{Binding SelectProfileCommand}'/>
        </StackPanel>
        <Button Content='{StaticResource ID_PROFILE_CANCEL}' Command='{Binding CancelCommand}'/>
    </Grid>
</Grid>
"
            }, {
                "FrostyEditor/Views/Windows/IDK",
                @"
<Grid Background=""Transparent"">
    <Grid.RowDefinitions>
        <RowDefinition Height=""*""/>
        <RowDefinition Height=""Auto""/>
    </Grid.RowDefinitions>
        
    <Grid Grid.Row=""0"">
        <ListBox ItemsSource=""{Binding Profiles}"" SelectedItem=""{Binding SelectedProfile}"">
            <ListBox.ItemTemplate>
                <DataTemplate>
                    <StackPanel>
                        <TextBlock Text=""{Binding Name}""/>
                        <TextBlock Text=""{Binding Path}""/>
                    </StackPanel>
                </DataTemplate>
            </ListBox.ItemTemplate>
        </ListBox>
    </Grid>
        
    <Grid Grid.Row=""1"">
        <StackPanel HorizontalAlignment=""Right"" Orientation=""Horizontal"">
            <Button Content=""{StaticResource ID_PROFILE_ADD}"" Command=""{Binding AddProfileCommand}""/>
            <Button Content=""{StaticResource ID_PROFILE_SELECT}"" Command=""{Binding SelectProfileCommand}""/>
        </StackPanel>
        <Button Content=""{StaticResource ID_PROFILE_CANCEL}"" Command=""{Binding CancelCommand}""/>
    </Grid>
</Grid>
"
            }
        };

        return xamlOverride;
    }
}
