namespace AppMAUIGallery.Views.Utils.Triggers;

public class AgeTrigger : TriggerAction<Entry>
{
    protected override void Invoke(Entry entry)
    {
        var age = entry.Text;
        if (!IsValidAge(age))
        {
            entry.TextColor = Colors.Red;
        }
        else
        {
            entry.TextColor = Colors.Green;
        }
    }

    private static bool IsValidAge(string age)
        => int.TryParse(age, out var ageInt) && ageInt >= 18;
}
