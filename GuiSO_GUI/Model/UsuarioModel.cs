namespace GuiSO_GUI.Model;

public class UsuarioModel
{
    public string Nombre { get; set; }
    public bool IsBackedUp { get; set; }
    public string Imagen { get; set; }
    
    public string MessageBackedUp{
        get
        {
            if (IsBackedUp)
                return $"Copia de seguridad encontrada";
            return $"Copia de seguridad no encontrada";
        }
    }

    public UsuarioModel(string nombre, bool isBackedUp)
    {
        this.Nombre = nombre;
        this.Imagen = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/baboon.jpg";
        this.IsBackedUp = isBackedUp;
    }
    
}