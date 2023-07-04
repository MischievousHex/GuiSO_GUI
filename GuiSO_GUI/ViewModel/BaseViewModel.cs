using CommunityToolkit.Mvvm.ComponentModel;

namespace GuiSO_GUI.ViewModel;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty] [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    private bool _isBusy = false;

    [ObservableProperty] public string title;

    public bool IsNotBusy => !IsBusy;
}