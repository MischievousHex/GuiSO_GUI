namespace GuiSO_GUI.View;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }
    
    private void ListarUsuariosBtn_OnClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"{nameof(UsuariosPage)}", true);
    }

    private void ConsultarProcesosBtn_OnClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"{nameof(ProcesosPage)}", true);
    }

    private void RealizarRespaldoBtn_OnClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"{nameof(RespaldoPage)}", true);
    }

    private void SalirBtn_OnClicked(object sender, EventArgs e)
    {
        Application.Current?.CloseWindow(Application.Current.MainPage.Window);
    }
    
}