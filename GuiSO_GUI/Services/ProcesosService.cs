using GuiSO_GUI.Model;

namespace GuiSO_GUI.Services;

public class ProcesosService
{
    private SystemManagementHandler _systemManagementHandler = new SystemManagementHandler();
    
    public List<ProcesoModel> GetProcesos()
    {
        return _systemManagementHandler.QueryProcesos();
    }
}