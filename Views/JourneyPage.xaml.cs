namespace Workup.Views;

public partial class JourneyPage : ContentPage
{
    public JourneyPage(JourneyViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = new JourneyViewModel();
    }
}