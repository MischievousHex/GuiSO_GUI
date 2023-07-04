using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using GuiSO_GUI.Model;
using GuiSO_GUI.Services;

namespace GuiSO_GUI.ViewModel;

public partial class ProcesosViewModel : BaseViewModel
{
    public ObservableCollection<ProcesoModel> ProcesoModels { get; } = new();
    private ProcesosService _procesosService;

    public ProcesosViewModel(ProcesosService procesosService){
        _procesosService = procesosService;
    }

    [RelayCommand]
    async Task GetProcesos()
    {
        if (IsBusy)
            return;

        try
        {
            IsBusy = true;
            var procesos = await _procesosService.GetProcesos();

            if(ProcesoModels.Count != 0)
                ProcesoModels.Clear();
                
            foreach(var proceso in procesos)
                ProcesoModels.Add(proceso);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"No se pudo obtener los procesos: {ex.Message}");
            await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
        }
        finally
        {
            IsBusy = false;
        }
    }
    
}