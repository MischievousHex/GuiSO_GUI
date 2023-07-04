namespace GuiSO_GUI.Model;

public class ProcesoModel
{
    public string Nombre { get; set; }
    public string NombreText => $"Nombre: {this.Nombre}";

    public string Pid { get; set; }
    public string PidText => $"PID: {this.Pid}";

    public double Cpu { get; set; }
    public string CpuText => $"CPU: {this.Cpu}%";

    public string Estado { get; set; }
    public string EstadoText => $"Estado: {this.Estado}";

    public ProcesoModel(string nombre, string pid, double cpu, string estado)
    {
        Nombre = nombre;
        Pid = pid;
        Cpu = cpu;
        Estado = estado;
    }

    public override string ToString()
    {
        return $"{nameof(Nombre)}: {Nombre}, {nameof(Pid)}: {Pid}, {nameof(Cpu)}: {Cpu}, {nameof(Estado)}: {Estado}";
    }
}