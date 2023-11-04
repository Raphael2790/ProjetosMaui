using CommunityToolkit.Mvvm.ComponentModel;
using ShoppingCenter.Models;

namespace ShoppingCenter.App.ViewModels.Tickets;

[QueryProperty(nameof(Ticket), "ticket")]
public partial class ResultPageViewModel : ObservableObject
{
    [ObservableProperty]
    private Ticket ticket;

    [ObservableProperty]
    private int tolerance = 30;
}
