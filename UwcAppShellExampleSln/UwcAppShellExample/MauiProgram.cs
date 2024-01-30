using Microsoft.Extensions.Logging;
using Microsoft.Maui.Hosting;
using SkiaSharp.Views.Maui.Controls.Hosting;
using UwcAppShellExample.Interfaces;
using UwcAppShellExample.Services;

namespace UwcAppShellExample
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseSkiaSharp()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

              
            /*    builder.Services.AddTransient<IMonkeyMaker, MonkeyMaker>();
                builder.Services.AddSingleton<HomePage>();
                builder.Services.AddSingleton<BotPage>();
                builder.Services.AddSingleton<MonkeyListPage>();
                builder.Services.AddSingleton<DotnetBotDemoPage>();
            */

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
