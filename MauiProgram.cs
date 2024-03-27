namespace Workup;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("FontAwesome6FreeBrands.otf", "FAB");
				fonts.AddFont("FontAwesome6FreeRegular.otf", "FAR");
				fonts.AddFont("FontAwesome6FreeSolid.otf", "FAS");
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<HomeViewModel>();

		builder.Services.AddSingleton<HomePage>();

		builder.Services.AddSingleton<AlarmViewModel>();

		builder.Services.AddSingleton<AlarmPage>();

		builder.Services.AddSingleton<SettingsViewModel>();

		builder.Services.AddSingleton<SettingsPage>();

        builder.Services.AddSingleton<JourneyViewModel>();

        builder.Services.AddSingleton<JourneyPage>();


        builder.Services.AddSingleton<CalculatorViewModel>();

        builder.Services.AddSingleton<CalculatorPage>();

        return builder.Build();
	}
}
