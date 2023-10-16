using AppMAUIGallery.Models;
using System.Web;

namespace AppMAUIGallery.Views.Shells.Pages;

[QueryProperty(nameof(Message), "msg")]
[QueryProperty(nameof(Person), "person")]
public partial class Page02Step01WithParameters : ContentPage
{
	private string _message;

	public string Message
	{
        get => _message;
        set
		{
            _message = HttpUtility.UrlDecode(value);
			LblMsgParameter.Text = _message;
        }
    }

	private Person _person;

	public Person Person
	{
        get => _person;
        set
		{
            _person = value;
            LblPersonParameter.Text = $"A pessoa recebida é : {_person.Name}({_person.Email})";
        }
    }

	public Page02Step01WithParameters()
	{
		InitializeComponent();
	}
}