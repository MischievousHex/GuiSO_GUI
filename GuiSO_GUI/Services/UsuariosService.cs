using System.Collections.ObjectModel;
using GuiSO_GUI.Model;
using System.Linq;

namespace GuiSO_GUI.Services;

public class UsuariosService
{
    public List<UsuarioModel> _usuarioModels { get; }
    private SystemManagementHandler _systemManagementHandler = new();

    public UsuariosService()
    {
        this._usuarioModels = _systemManagementHandler.QueryUsuarios();
    }
    
    public async Task<List<UsuarioModel>> GetUsuarios()
    {
        return this._usuarioModels;
    }

    public async Task<List<UsuarioModel>> GetBackedUpUsuarios()
    {
        return this._usuarioModels.Where(usuario => !usuario.IsBackedUp).ToList();
    }
    
}