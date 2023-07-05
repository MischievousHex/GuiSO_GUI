namespace GuiSO_GUI.Model;

public class UsuarioModel
{

    public string Nombre { get; set; }
    public bool IsBackedUp { get; set; }
    public string Imagen { get; set; }
    public string[] Grupos { get; set; }
    public string UltimaFechaAcceso { get; set; }
    
    public UsuarioModel(string nombre, bool isBackedUp, string[] grupos, string ultimaFechaAcceso)
    {
        Nombre = nombre;
        IsBackedUp = isBackedUp;
        Imagen = "pochy.jpg";
        Grupos = grupos;
        UltimaFechaAcceso = ultimaFechaAcceso;
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