using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuiSO_GUI.ViewModel;

namespace GuiSO_GUI.View;

public partial class ProcesosPage : ContentPage
{
    public ProcesosPage(ProcesosViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}