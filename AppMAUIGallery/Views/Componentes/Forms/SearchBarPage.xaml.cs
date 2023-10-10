namespace AppMAUIGallery.Views.Componentes.Forms;

public partial class SearchBarPage : ContentPage
{
	public SearchBarPage()
	{
		InitializeComponent();
	}

    private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
    {
        LblValue.Text = ((SearchBar)sender).Text;
    }

    private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {

    }
}