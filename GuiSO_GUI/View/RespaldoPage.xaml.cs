using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiSO_GUI.View;

public partial class RespaldoPage : ContentPage
{
    public RespaldoPage()
    {
        InitializeComponent();
    }
    
    private void RealizarRespaldoBtn_OnClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..", true);
    }

    private void CancelarRespaldoBtn_OnClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"..", true);
    }
    
}