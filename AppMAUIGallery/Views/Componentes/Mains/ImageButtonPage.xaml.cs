namespace AppMAUIGallery.Views.Componentes.Mains;

public partial class ImageButtonPage : ContentPage
{
	private bool _isOn = false;

	public ImageButtonPage()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		_isOn = !_isOn;

		var img = _isOn ? "poweron.png" : "poweroff.png";

		var imgButton = sender as ImageButton;

		imgButton.Source = img;
    }
}