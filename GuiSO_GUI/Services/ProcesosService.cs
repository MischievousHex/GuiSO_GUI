using GuiSO_GUI.Model;

namespace GuiSO_GUI.Services;

public class ProcesosService
{
    private List<ProcesoModel> _procesoModels { get; }

    public ProcesosService()
    {
        this._procesoModels = new();
        _procesoModels.Add(new ProcesoModel("Proceso1", "12", 10.52, "Running"));
        _procesoModels.Add(new ProcesoModel("Proceso2", "23", 5.14, "Waiting"));
        _procesoModels.Add(new ProcesoModel("Proceso3", "34", 12.23, "Running"));
        _procesoModels.Add(new ProcesoModel("Proceso1", "12", 10.52, "Running"));
        _procesoModels.Add(new ProcesoModel("Proceso2", "23", 5.14, "Waiting"));
        _procesoModels.Add(new ProcesoModel("Proceso3", "34", 12.23, "Running"));
        _procesoModels.Add(new ProcesoModel("Proceso1", "12", 10.52, "Running"));
        _procesoModels.Add(new ProcesoModel("Proceso2", "23", 5.14, "Waiting"));
        _procesoModels.Add(new ProcesoModel("Proceso3", "34", 12.23, "Running"));
        _procesoModels.Add(new ProcesoModel("Proceso1", "12", 10.52, "Running"));
        _procesoModels.Add(new ProcesoModel("Proceso2", "23", 5.14, "Waiting"));
        _procesoModels.Add(new ProcesoModel("Proceso3", "34", 12.23, "Running"));
        _procesoModels.Add(new ProcesoModel("Proceso1", "12", 10.52, "Running"));
        _procesoModels.Add(new ProcesoModel("Proceso2", "23", 5.14, "Waiting"));
        _procesoModels.Add(new ProcesoModel("Proceso3", "34", 12.23, "Running"));
        _procesoModels.Add(new ProcesoModel("Proceso1", "12", 10.52, "Running"));
        _procesoModels.Add(new ProcesoModel("Proceso2", "23", 5.14, "Waiting"));
        _procesoModels.Add(new ProcesoModel("Proceso3", "34", 12.23, "Running"));
    }
    
    public async Task<List<ProcesoModel>> GetProcesos()
    {
        return this._procesoModels;
    }
}