namespace Workup.Views;

public partial class AlarmPage : ContentPage
{
	public AlarmPage(AlarmViewModel viewModel)
	{
        InitializeComponent();
        BindingContext = new AlarmViewModel();

       
    }
}
