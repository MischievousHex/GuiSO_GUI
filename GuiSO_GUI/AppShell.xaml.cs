using GuiSO_GUI.View;

namespace GuiSO_GUI;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(UsuariosPage), typeof(UsuariosPage));
        Routing.RegisterRoute(nameof(ProcesosPage), typeof(ProcesosPage));
        Routing.RegisterRoute(nameof(RespaldoPage), typeof(RespaldoPage));

    }
}