using ShoppingCenter.Models;
using System.Text.Json;

namespace ShoppingCenter.App.Libraries.Stores;

public class TicketPreferencesStore
{
    private readonly string _key = "tickets";

    public void Save(Ticket ticket)
    {
        List<Ticket> tickets;
        if (Preferences.Default.ContainsKey(_key))
        {
            var ticketsJson = Preferences.Default.Get<string>(_key, string.Empty);
            tickets = JsonSerializer.Deserialize<List<Ticket>>(ticketsJson);
        }
        else
        {
            tickets = new List<Ticket>();
        }

        tickets.Add(ticket);
        Preferences.Default.Clear();
        Preferences.Default.Set(_key, JsonSerializer.Serialize(tickets));
    }

    public List<Ticket> Load()
    {
        if (Preferences.Default.ContainsKey(_key))
        {
            var ticketsJson = Preferences.Default.Get<string>(_key, string.Empty);
            return JsonSerializer.Deserialize<List<Ticket>>(ticketsJson);
        }

        return new List<Ticket>();
    }
}
