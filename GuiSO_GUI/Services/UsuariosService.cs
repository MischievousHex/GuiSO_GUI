using System.Collections.ObjectModel;
using GuiSO_GUI.Model;

namespace GuiSO_GUI.Services;

public class UsuariosService
{
    private List<UsuarioModel> _usuarioModels { get; }

    public UsuariosService()
    {
        this._usuarioModels = new();
        _usuarioModels.Add(new UsuarioModel("Usuario1", true));
        _usuarioModels.Add(new UsuarioModel("Usuario2", false));
        _usuarioModels.Add(new UsuarioModel("Usuario3", true));
    }
    
    public async Task<List<UsuarioModel>> GetUsuarios()
    {
        return this._usuarioModels;
    }
    
}