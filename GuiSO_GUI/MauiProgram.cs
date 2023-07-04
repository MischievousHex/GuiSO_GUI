using Microsoft.Extensions.Logging;
using GuiSO_GUI.Model;
using GuiSO_GUI.Services;
using GuiSO_GUI.View;
using GuiSO_GUI.ViewModel;

namespace GuiSO_GUI;

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
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<UsuariosPage>();
        builder.Services.AddSingleton<UsuariosService>();
        builder.Services.AddSingleton<UsuariosViewModel>();

        return builder.Build();
    }
}