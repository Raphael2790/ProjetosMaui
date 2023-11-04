using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShoppingCenter.App.Services;

namespace ShoppingCenter.App.ViewModels.Tickets;

public partial class CameraPageViewModel : ObservableObject
{
    [RelayCommand]
    private void BarcodeDetected(string ticketNumber)
    {
        var service = App.Current.Handler.MauiContext.Services.GetRequiredService<TicketService>();

        var ticket = service.GetTicket(ticketNumber);

        if (ticket == null)
        {
            App.Current.MainPage
                .DisplayAlert("Ticket não encontrado!", $"Não localizamos um ticket com numero {ticketNumber}", "Ok");
            return;
        }

        var param = new Dictionary<string, object>
        {
            {"ticket", ticket }
        };

        MainThread.BeginInvokeOnMainThread(async () => await Shell.Current.GoToAsync("../pay", param));
    }
}
