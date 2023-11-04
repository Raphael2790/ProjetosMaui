namespace ShoppingCenter.App.Views.Tickets;

public partial class ScanPage : ContentPage
{
	public ScanPage()
	{
		InitializeComponent();
	}

    private void CursorFix(object sender, TextChangedEventArgs e)
    {
		var entry = sender as Entry;

		if (entry.Text.Length > 0)
			entry.CursorPosition = entry.Text.Length;
    }
}