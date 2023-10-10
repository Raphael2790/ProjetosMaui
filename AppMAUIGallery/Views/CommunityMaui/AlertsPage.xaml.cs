using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace AppMAUIGallery.Views.CommunityMaui;

public partial class AlertsPage : ContentPage
{
	public AlertsPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		var options = new SnackbarOptions
		{
			BackgroundColor = Colors.White,
			TextColor = Colors.Green,
		};

		var snackBar = Snackbar.Make("Ocorreu um erro inesperado!", null, "OK", TimeSpan.FromSeconds(5), options, null);

		snackBar.Show();
    }

    private void OnButtonClicked_ShowToast(object sender, EventArgs e)
    {
		var toast = Toast.Make("Ocorreu um erro inesperado!", ToastDuration.Long, 18);
		toast.Show();
    }
}