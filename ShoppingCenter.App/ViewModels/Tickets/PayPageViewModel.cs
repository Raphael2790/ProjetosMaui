using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShoppingCenter.App.Libraries.Stores;
using ShoppingCenter.Models;

namespace ShoppingCenter.App.ViewModels.Tickets;

[QueryProperty(nameof(Ticket), "ticket")]
public partial class PayPageViewModel : ObservableObject
{
    private readonly double _hourValue = 0.10;
    private Ticket ticket;

    public Ticket Ticket
    {
        get => ticket;
        set 
        {
            GenerateDateOutAndTolerance(value);
            GeneratePrice(value);
            SetProperty(ref ticket, value);
        }
    }

    [ObservableProperty]
    private string pixCode = "00020126360014BR.GOV.BCB.PIX0114+5561999...";

    private void GenerateDateOutAndTolerance(Ticket ticket)
    {
        var random = new Random();
        var hour = random.Next(0, 24);
        var minute = random.Next(0, 60);

        ticket.DateOut = DateTime.Now.AddHours(hour).AddMinutes(minute);
        ticket.DateTolerance = ticket.DateOut.AddMinutes(30);
    }

    private void GeneratePrice(Ticket ticket)
    {
        var dif = ticket.DateOut.Ticks - ticket.DateIn.Ticks;
        var minutes = new TimeSpan(dif).TotalMinutes;

        ticket.Price = minutes * _hourValue;
    }

    [RelayCommand]
    private async Task CopyAndPaste()
    {
        await Clipboard.SetTextAsync(PixCode);

        await App.Current.MainPage
            .DisplayAlert("Pix Copiado!", "O código pix foi copiado para a área de transferência", "Ok");

        await Task.Delay(5000);

        var storage = App.Current.Handler.MauiContext.Services.GetService<TicketPreferencesStore>();

        storage.Save(Ticket);

        var param = new Dictionary<string, object>
        {
            {"ticket", Ticket }
        };
        await Shell.Current.GoToAsync("../result", param);
    }

}
