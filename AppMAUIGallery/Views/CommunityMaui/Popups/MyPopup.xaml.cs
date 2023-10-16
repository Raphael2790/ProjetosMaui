using CommunityToolkit.Maui.Views;

namespace AppMAUIGallery.Views.CommunityMaui.Popups;

public partial class MyPopup : Popup
{
	public MyPopup()
	{
		InitializeComponent();
	}

    private void OnClose(object sender, EventArgs e)
    {
		Close();
    }

    private void OnClickSaveEmailAndClose(object sender, EventArgs e)
    {
        // Save email

        Close();
    }
}