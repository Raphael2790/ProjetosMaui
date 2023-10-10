namespace AppMAUIGallery.Views.Utils;

public partial class PlatformIdiomPage : ContentPage
{
	public PlatformIdiomPage()
	{
		InitializeComponent();

#if WINDOWS
        DisplayAlert("Alert", "This is a alert from conditional compilation", "OK");
#endif

		if(Device.RuntimePlatform == Device.WinUI)
		{
			DisplayAlert("Alert", "This is a WinUI platform", "OK");
		}

		if(Device.Idiom == TargetIdiom.Desktop)
		{
			DisplayAlert("Alert", "This is a Desktop platform", "OK");
		}
	}
}