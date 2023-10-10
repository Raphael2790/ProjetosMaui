namespace AppMAUIGallery.Views.Styles;

public partial class VisualStateManagerPage : ContentPage
{
	public VisualStateManagerPage()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

		VisualStateManager.GoToState((Label)sender, "Tapped");
    }
}