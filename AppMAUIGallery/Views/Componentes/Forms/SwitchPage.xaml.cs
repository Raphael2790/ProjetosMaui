namespace AppMAUIGallery.Views.Componentes.Forms;

public partial class SwitchPage : ContentPage
{
	public SwitchPage()
	{
		InitializeComponent();
	}

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
		LblStatus.Text = e.Value ? "Ligado" : "Desligado";
    }
}