namespace AppMAUIGallery.Views.Shells.Pages;

public partial class Page01Step01 : ContentPage
{
	public Page01Step01()
	{
		InitializeComponent();
	}

    private void GoBack(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }

    private void GoNext(object sender, EventArgs e)
    {
        //Navega��o relativa onde as rotas s�o concatenadas com o caminho atual
        Shell.Current.GoToAsync("../page01step02");
    }
}