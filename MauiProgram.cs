using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Hosting; // Ensure this directive is included
using Microsoft.Maui.Hosting; // Ensure this directive is included
using Microsoft.Maui;
using CommunityToolkit.Maui;
using Mopups.Interfaces;
using Mopups.Hosting;
using Mopups.Services;

namespace Wellness_Wizards_App
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>() // This initializes your MAUI application
                .UseMauiCommunityToolkit()
                .ConfigureMopups()
                .ConfigureFonts(fonts =>
                {
                    // Add your custom fonts here
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddHybridWebView();
            builder.Services.AddSingleton<IPopupNavigation>(MopupService.Instance);
            // This section adds debug logging, but only in the Debug build configuration
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build(); // This compiles the MauiApp
        }
    }
}