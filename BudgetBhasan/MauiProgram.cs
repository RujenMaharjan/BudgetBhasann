using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using BudgetBhasan.Services;

namespace BudgetBhasan;

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
            });

        builder.Services.AddMauiBlazorWebView();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        // Register MudBlazor services
        builder.Services.AddMudServices();

        // Register Database as a singleton
        builder.Services.AddSingleton<Database>();

        // Register AuthenticationService
        builder.Services.AddSingleton<AuthenticationService>();

        return builder.Build();
    }
}