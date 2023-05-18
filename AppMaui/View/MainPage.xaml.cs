using AppMaui.ViewModel;

namespace AppMaui.View;

public partial class MainPage : ContentPage
{
	public MainPage(DrinksViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}