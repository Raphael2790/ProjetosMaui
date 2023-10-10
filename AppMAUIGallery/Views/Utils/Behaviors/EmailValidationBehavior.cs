namespace AppMAUIGallery.Views.Utils.Behaviors;

public class EmailValidationBehavior : Behavior<Entry>
{
    protected override void OnAttachedTo(Entry bindable)
    {
        bindable.TextChanged += OnTextChangeValidate;
        base.OnAttachedTo(bindable);
    }

    protected override void OnDetachingFrom(Entry bindable)
    {
        bindable.TextChanged -= OnTextChangeValidate;
        base.OnDetachingFrom(bindable);
    }

    private void OnTextChangeValidate(object sender, TextChangedEventArgs e)
    {
        var email = e.NewTextValue;
        var entry = sender as Entry;
        
        if (email.Length > 0)
        {
            if (!IsValidEmail(email))
            {
                entry.TextColor = Colors.Red;
            }
            else
            {
                entry.TextColor = Colors.Green;
            }
        }
    }

    private static bool IsValidEmail(string email)
    {
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }
}
