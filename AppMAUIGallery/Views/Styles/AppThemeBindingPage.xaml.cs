namespace AppMAUIGallery.Views.Styles;

public partial class AppThemeBindingPage : ContentPage
{
	public AppThemeBindingPage()
	{
		InitializeComponent();

		var theme = Application.Current.RequestedTheme;

		Application.Current.UserAppTheme = AppTheme.Dark;
	}
}