using AppMaui.ViewModel;

namespace AppMaui.View;

public partial class DrinkDetailsPage : ContentPage
{
	public DrinkDetailsPage(DrinkDetailsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel ;
	}
}