namespace ShoppingCenter.App.Views.Cinemas;

public partial class DetailsPage : ContentPage
{
	bool firstTime = false;

	public DetailsPage()
	{
		InitializeComponent();
	}

    private void PlayPause(object sender, TappedEventArgs e)
    {
		var btn = (Image)sender;
		if (!firstTime)
		{
			var mediaWidthHalf = player.Width / 2 - btn.Width + 10;
			var mediaHeightHalf = player.Height / 2 - btn.Height;

			btnPause.TranslateTo(-mediaWidthHalf, mediaHeightHalf, 500);

			firstTime = true;

			MovieText.TranslateTo(0, 40);
		}

		if(player.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Playing)
		{
			player.Pause();
			btnPause.Source = ImageSource.FromFile("play.png");
		}
		else
		{
			player.Play();
			btnPause.Source = ImageSource.FromFile("pause.png");
		}
    }
}