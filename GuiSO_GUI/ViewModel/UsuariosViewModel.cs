using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using GuiSO_GUI.Model;
using GuiSO_GUI.Services;

namespace GuiSO_GUI.ViewModel;

public partial class UsuariosViewModel : BaseViewModel
{
    
    public ObservableCollection<UsuarioModel> UsuarioModels { get; } = new();
    private UsuariosService _usuariosService;

    public UsuariosViewModel(UsuariosService usuarioService){
        _usuariosService = usuarioService;
    }

    [RelayCommand]
    async Task GetUsuarios()
    {
        if (IsBusy)
            return;

        try
        {
            IsBusy = true;
            var usuarios = await _usuariosService.GetUsuarios();

            if(UsuarioModels.Count != 0)
                UsuarioModels.Clear();
                
            foreach(var monkey in usuarios)
                UsuarioModels.Add(monkey);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"No se pudo obtener los usuarios: {ex.Message}");
            await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
        }
        finally
        {
            IsBusy = false;
        }
    }
}