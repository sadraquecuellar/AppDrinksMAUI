using AppMaui.Service;
using AppMaui.View;
using AppMaui.ViewModel;
using Microsoft.Extensions.Logging;

namespace AppMaui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
        builder.Services.AddSingleton<DrinkService>();
        builder.Services.AddSingleton<DrinksViewModel>();
        builder.Services.AddSingleton<MainPage>();

        builder.Services.AddTransient<DrinkDetailsViewModel>();
        builder.Services.AddTransient<DrinkDetailsPage>();

        return builder.Build();
	}
}
