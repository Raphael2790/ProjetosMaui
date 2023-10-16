namespace AppMAUIGallery.Views.Shells.Pages;

public partial class Page01Step02 : ContentPage
{
	public Page01Step02()
	{
		InitializeComponent();
	}

    private void GoToRegisterStep02(object sender, EventArgs e)
    {
		//Navega��o absoluta onde as duas barras indicam que deve-se iniciar a navega��o a partir da raiz
		Shell.Current.GoToAsync("//cadastro/passo02");
    }

    private void GoToRegisterStep01(object sender, EventArgs e)
    {
        //Navega��o absoluta onde as tr�s barras indicam uma pesquisa por uma rota nomeada
        Shell.Current.GoToAsync("///passo01");
    }
}