using CommunityToolkit.Maui.Core.Platform;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShoppingCenter.App.Services;

namespace ShoppingCenter.App.ViewModels.Tickets;

public partial class ScanPageViewModel : ObservableObject
{
    [ObservableProperty]
    private string ticketNumber;

    [RelayCommand]
    private void Scan()
    {
        Shell.Current.GoToAsync("camera");
    }

    [RelayCommand]
    private async Task CheckTicketNumber(Entry ticketEntry)
    {
        if(TicketNumber?.Length < 15)
            return;

        var service = App.Current.Handler.MauiContext.Services.GetRequiredService<TicketService>();

        var ticket = service.GetTicket(TicketNumber);

        if(ticket == null)
        {
            await App.Current.MainPage
                    .DisplayAlert("Ticket não encontrado!", $"Não localizamos um ticket com numero {TicketNumber}", "Ok");
            return;
        }

        var param = new Dictionary<string, object>
        {
            {"ticket", ticket }
        };
        await Shell.Current.GoToAsync("pay", param);

        await ticketEntry.HideKeyboardAsync(CancellationToken.None);

        TicketNumber = string.Empty;
    }

    [RelayCommand]
    private void List()
    {
        Shell.Current.GoToAsync("list");
    }
}
