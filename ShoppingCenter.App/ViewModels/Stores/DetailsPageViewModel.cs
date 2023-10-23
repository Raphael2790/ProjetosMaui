using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShoppingCenter.Models;

namespace ShoppingCenter.App.ViewModels.Stores;

[QueryProperty(nameof(Establishment), "establishment")]
public partial class DetailsPageViewModel : ObservableObject
{
    [ObservableProperty]
    private Establishment establishment;

    [RelayCommand]
    public void OnTapToBack() => Shell.Current.GoToAsync("..");
}
