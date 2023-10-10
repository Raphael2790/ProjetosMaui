namespace AppMAUIGallery.Views.Componentes.Forms;

public partial class RadioButtonPage : ContentPage
{
	public RadioButtonPage()
	{
		InitializeComponent();
	}

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		if(e.Value is true)
		{
			RadioButton radioButton = (RadioButton)sender;
			var content = radioButton.Content;
			LblResultAsk01.Text = $"Você escolheu a opção {content}";
		}
    }
}