using CommunityToolkit.Maui.Core.Primitives;

namespace AppMAUIGallery.Views.CommunityMaui;

public partial class MediaElementPage : ContentPage
{
	public MediaElementPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		MediaPlayer.Play();

		//MediaPlayer.Pause();
		//MediaPlayer.Stop();
		//MediaPlayer.SeekTo(TimeSpan.FromSeconds(0));
    }
}