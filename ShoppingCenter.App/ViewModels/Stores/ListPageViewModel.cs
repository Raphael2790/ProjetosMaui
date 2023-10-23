using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShoppingCenter.App.Services;
using ShoppingCenter.Models;

namespace ShoppingCenter.App.ViewModels.Stores;

public partial class ListPageViewModel : ObservableObject
{
    [ObservableProperty]
    private string textSearch;

    private List<Establishment> establishmentsFull;

    [ObservableProperty]
    private List<Establishment> establishmentsFiltered;

    public ListPageViewModel()
    {
        var service = App.Current.Handler.MauiContext.Services.GetService<StoreService>();
        establishmentsFull = service.GetStores();
        establishmentsFiltered = establishmentsFull.ToList();
    }

    [RelayCommand]
    public void OnTextChangedFilterList()
    {
        EstablishmentsFiltered =
            establishmentsFull.Where(a => a.Name.ToLower().Contains(TextSearch.ToLower()))
            .ToList();
    }

    [RelayCommand]
    public async void OnTapEstablishmentGoToDetails(Establishment establishment)
    {
        await Shell.Current.GoToAsync("details", new Dictionary<string, object>
        {
            { "establishment", establishment }
        });
    }
}
