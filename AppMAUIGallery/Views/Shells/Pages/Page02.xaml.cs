using AppMAUIGallery.Models;
using System.Web;

namespace AppMAUIGallery.Views.Shells.Pages;

public partial class Page02 : ContentPage
{
	public Page02()
	{
		InitializeComponent();
	}

    private void GoToStep1WithSimpleParameter(object sender, EventArgs e)
    {
		var mensagem = "Este é um parâmetro passado de uma página para outra";
		var encodedMessage = HttpUtility.UrlEncode(mensagem);

		Shell.Current.GoToAsync($"//page02/page02step01?msg={encodedMessage}");
    }

    private void GoToStep01WithComplexParameter(object sender, EventArgs e)
    {
		var person = new Person
		{
			Name = "João da Silva",
			Email = "joão@email.com"
		};

        var mensagem = "Este é um parâmetro passado de uma página para outra";
        var encodedMessage = HttpUtility.UrlEncode(mensagem);

		var dictionary = new Dictionary<string, object>
		{
			{"msg", encodedMessage},
            {"person", person }
		};

		Shell.Current.GoToAsync($"//page02/page02step01", dictionary);
    }
}