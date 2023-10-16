using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace AppMAUIGallery
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
                .ConfigureFonts(fonts =>
            {
                fonts.AddFont("Icons.ttf", "Icons");
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("PixelifySans-Bold.ttf", "PixelifySansBold");
                fonts.AddFont("PixelifySans-Regular.ttf", "PixelifySansRegular");
                fonts.AddFont("PixelifySans-Semibold.ttf", "PixelifySansSemibold");
                fonts.AddFont("PixelifySans-Medium.ttf", "PixelifySansMedium");
            });
#if DEBUG
            builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
    }
}