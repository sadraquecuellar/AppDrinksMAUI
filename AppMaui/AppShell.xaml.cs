using AppMaui.View;

namespace AppMaui;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(DrinkDetailsPage), typeof(DrinkDetailsPage) );
	}
}
