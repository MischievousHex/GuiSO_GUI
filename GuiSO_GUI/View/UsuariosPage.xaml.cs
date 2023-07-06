using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuiSO_GUI.ViewModel;

namespace GuiSO_GUI.View;

public partial class UsuariosPage : ContentPage
{
    public UsuariosPage(UsuariosViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
    }
}