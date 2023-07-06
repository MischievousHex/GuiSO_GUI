using CommunityToolkit.Mvvm.ComponentModel;
using GuiSO_GUI.Services;

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
        set
        {
            SetProperty(ref isBackUpQueued, value);
            if (value)
                SetProperty(ref messageBackedUp, "No se encontró una copia de seguridad.");
            else SetProperty(ref messageBackedUp, "Se encontró una copia de seguridad.");
        }
    }
    
    
    public UsuarioModel(string nombre, bool isBackedUp, string[] grupos, string ultimaFechaAcceso)
    {
        Random rnd = new Random();
        int sopasPercent = rnd.Next(0, 25);
        Nombre = nombre;
        IsBackedUp = FileSystemService.DirectoryExists($"C:\\CAMP_BACKUP\\{Nombre}");
        Imagen = (sopasPercent == 1) ? "sopas.jpeg" : "user.png";
        Grupos = grupos;
        UltimaFechaAcceso = ultimaFechaAcceso;
        IsBackUpQueued = false;
    }

    private string messageBackedUp;
    public string MessageBackedUp
    {
        get => messageBackedUp;
        set => SetProperty(ref messageBackedUp, value);
    }

    private string gruposTexto;

    // TODO esto no se sincroniza creo
    public string GruposTexto
    {
        get => String.Join(", ", this.Grupos);
    }
    

    public override string ToString()
    {
        return $"{nameof(Nombre)}: {Nombre}, {nameof(IsBackedUp)}: {IsBackedUp}, {nameof(Imagen)}: {Imagen}, {nameof(MessageBackedUp)}: {MessageBackedUp}";
    }
}