using System.Collections.ObjectModel;
using GuiSO_GUI.Model;
using System.Linq;

namespace GuiSO_GUI.Services;

public class UsuariosService
{
    private List<UsuarioModel> _usuarioModels { get; }

    public UsuariosService()
    {
        this._usuarioModels = new();
        _usuarioModels.Add(new UsuarioModel("Usuario1", false, new []{"Grupo1", "Administradores", "Grupo2"}, "10 Jun 2023"));
        _usuarioModels.Add(new UsuarioModel("Usuario2", false, new []{"Grupo2", "Usuarios", "Grupo3"}, "5 Mar 2023"));
        _usuarioModels.Add(new UsuarioModel("Usuario3", false, new []{"Grupo1", "Trabajadores"}, "2 Jul 2023"));
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