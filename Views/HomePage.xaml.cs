namespace Workup.Views;

public partial class HomePage : ContentPage
{
	public HomePage(HomeViewModel viewModel)
	{
        InitializeComponent();

        BindingContext = new HomeViewModel();
    }


}
