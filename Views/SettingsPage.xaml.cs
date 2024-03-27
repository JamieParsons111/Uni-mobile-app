namespace Workup.Views;

public partial class SettingsPage : ContentPage
{
	public SettingsPage(SettingsViewModel viewModel)
	{
        InitializeComponent();
        BindingContext = new SettingsViewModel();
    }
}
