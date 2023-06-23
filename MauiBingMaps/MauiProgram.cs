using CommunityToolkit.Maui.Maps;
using Microsoft.Extensions.Logging;

namespace MauiBingMaps;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
        builder
			.UseMauiApp<App>()
			// Initialize the .NET MAUI Community Toolkit Maps by adding the below line of code
			.UseMauiCommunityToolkitMaps("VeJ9bE3ExnUvxTHrQoHi~KcrGHjwzo15VChR7U-tguw~AhI5m5S4V-6l4qPnOamkvP9raLxWC2EtB8JYi7HYjt76-Q96AfCvBrfIq3vUrMEi")
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
