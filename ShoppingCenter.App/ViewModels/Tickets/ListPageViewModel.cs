using CommunityToolkit.Mvvm.ComponentModel;
using ShoppingCenter.App.Libraries.Stores;
using ShoppingCenter.Models;

namespace ShoppingCenter.App.ViewModels.Tickets;

public partial class ListPageViewModel : ObservableObject
{
    [ObservableProperty]
    private List<Ticket> tickets;

    public ListPageViewModel()
    {
        var storage = App.Current.Handler.MauiContext.Services.GetService<TicketPreferencesStore>();

        Tickets = storage.Load();
    }
}
