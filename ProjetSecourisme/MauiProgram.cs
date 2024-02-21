using Microsoft.Extensions.Logging;
using ProjetSecourisme.Views;
using ProjetSecourisme.Data;


namespace ProjetSecourisme;

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
        builder.Services.AddSingleton<respiration>();
        builder.Services.AddSingleton<Documentation>();
        builder.Services.AddSingleton<questionnaire>();

        builder.Services.AddTransient<SignupPage>();
        builder.Services.AddSingleton<SignInPage>();
        builder.Services.AddSingleton<Home>();
        builder.Services.AddSingleton<Alerte>();
        builder.Services.AddSingleton<LoginListPage>();
        builder.Services.AddTransient<LoginItemPage>();
        builder.Services.AddSingleton<Database>();


#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
