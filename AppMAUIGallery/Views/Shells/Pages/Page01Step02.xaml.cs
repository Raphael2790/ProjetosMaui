namespace AppMAUIGallery.Views.Shells.Pages;

public partial class Page01Step02 : ContentPage
{
	public Page01Step02()
	{
		InitializeComponent();
	}

    private void GoToRegisterStep02(object sender, EventArgs e)
    {
		//Navegação absoluta onde as duas barras indicam que deve-se iniciar a navegação a partir da raiz
		Shell.Current.GoToAsync("//cadastro/passo02");
    }

    private void GoToRegisterStep01(object sender, EventArgs e)
    {
        //Navegação absoluta onde as três barras indicam uma pesquisa por uma rota nomeada
        Shell.Current.GoToAsync("///passo01");
    }
}