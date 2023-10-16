using AppMAUIGallery.Views.CommunityMaui.Popups;
using CommunityToolkit.Maui.Views;

namespace AppMAUIGallery.Views.CommunityMaui;

public partial class PopupPage : ContentPage
{
	public PopupPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		var popup = new MyPopup();
		this.ShowPopup(popup);
    }
}