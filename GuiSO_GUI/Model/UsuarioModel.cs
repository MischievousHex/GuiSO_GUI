using CommunityToolkit.Mvvm.ComponentModel;

namespace GuiSO_GUI.Model;

public class UsuarioModel : ObservableObject
{
    private string nombre;
    public string Nombre {
        get => nombre;
        set => SetProperty(ref nombre, value);
    }
    private bool isBackedUp;
    public bool IsBackedUp
    {
        get => isBackedUp;
        set => SetProperty(ref isBackedUp, value);
    }

    private string imagen;

    public string Imagen
    {
        get => imagen;
        set => SetProperty(ref imagen, value);
    }

    private string[] grupos;

    public string[] Grupos
    {
        get => grupos;
        set => SetProperty(ref grupos, value);
    }

    private string ultimaFechaAcceso;

    public string UltimaFechaAcceso
    {
        get => ultimaFechaAcceso;
        set => SetProperty(ref ultimaFechaAcceso, value);
    }

    private bool isBackUpQueued;

    public bool IsBackUpQueued
    {
        get => isBackUpQueued;
        set => SetProperty(ref isBackUpQueued, value);
    }
    
    
    public UsuarioModel(string nombre, bool isBackedUp, string[] grupos, string ultimaFechaAcceso)
    {
        Nombre = nombre;
        IsBackedUp = isBackedUp;
        Imagen = "pochy.jpg";
        Grupos = grupos;
        UltimaFechaAcceso = ultimaFechaAcceso;
        IsBackUpQueued = false;
    }
    
    public string MessageBackedUp{
        get
        {
            if (IsBackedUp)
                return $"Copia de seguridad encontrada";
            return $"Copia de seguridad no encontrada";
        }
    }

    public string GruposTexto => String.Join(", ", this.Grupos);
    

    public override string ToString()
    {
        return $"{nameof(Nombre)}: {Nombre}, {nameof(IsBackedUp)}: {IsBackedUp}, {nameof(Imagen)}: {Imagen}, {nameof(MessageBackedUp)}: {MessageBackedUp}";
    }
}