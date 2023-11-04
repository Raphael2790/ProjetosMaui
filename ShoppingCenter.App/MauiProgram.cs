using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using ShoppingCenter.App.Libraries.Stores;
using ShoppingCenter.App.Services;
using ZXing.Net.Maui.Controls;

namespace ShoppingCenter.App
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseMauiCommunityToolkitMediaElement()
                .UseBarcodeReader()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Bold.ttf", "OpenSansBold");
                    fonts.AddFont("OpenSans-Light.ttf", "OpenSansLight");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<TicketPreferencesStore>();
            builder.Services.AddSingleton<StoreService>();
            builder.Services.AddSingleton<CinemaService>();
            builder.Services.AddSingleton<TicketService>();

            return builder.Build();
        }
    }
}