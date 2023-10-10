namespace AppMAUIGallery.Views.Utils.Behaviors;

public class AgeValidationBehavior : Behavior<Entry>
{
    override protected void OnAttachedTo(Entry bindable)
    {
        bindable.TextChanged += OnTextChangeValidate;
        base.OnAttachedTo(bindable);
    }

    override protected void OnDetachingFrom(Entry bindable)
    {
        bindable.TextChanged -= OnTextChangeValidate;
        base.OnDetachingFrom(bindable);
    }

    private void OnTextChangeValidate(object sender, TextChangedEventArgs e)
    {
        var age = e.NewTextValue;
        var entry = sender as Entry;
        
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
