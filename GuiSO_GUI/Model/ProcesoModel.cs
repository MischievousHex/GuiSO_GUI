using CommunityToolkit.Mvvm.ComponentModel;

namespace GuiSO_GUI.Model;

public class ProcesoModel : ObservableObject
{
    private string nombre;
    public string Nombre
    {
        get => nombre;
        set => SetProperty(ref nombre, value);
    }
    public string NombreText => $"Nombre: {this.Nombre}";

    private string pId;
    public string PId
    {
        get => pId;
        set => SetProperty(ref pId, value);
    }
    public string PIdText => $"PID: {this.PId}";

    private double cpu;
    public double Cpu
    {
        get => cpu;
        set => SetProperty(ref cpu, value);
    }
    public string CpuText => $"CPU: {this.Cpu}%";

    private string estado;
    public string Estado
    {
        get => estado;
        set => SetProperty(ref estado, value);
    }
    public string EstadoText => $"Estado: {this.Estado}";

    public ProcesoModel(string nombre, string pid, double cpu, string estado)
    {
        Nombre = nombre;
        PId = pid;
        Cpu = cpu;
        Estado = estado;
    }

    private bool isPaused;
    public bool IsPaused
    {
        get => isPaused;
        set => SetProperty(ref isPaused, value);
    }

    private bool isPauseScheduled;
    public bool IsPauseScheduled
    {
        get => isPauseScheduled;
        set => SetProperty(ref isPauseScheduled, value);
    }
    
    private bool isKillScheduled;
    public bool IsKillScheduled
    {
        get => isKillScheduled;
        set => SetProperty(ref isKillScheduled, value);
    }

    public override string ToString()
    {
        return $"{nameof(Nombre)}: {Nombre}, {nameof(PId)}: {PId}, {nameof(Cpu)}: {Cpu}, {nameof(Estado)}: {Estado}";
    }
}