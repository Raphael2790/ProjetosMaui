namespace AppMAUIGallery.Views.Componentes.Forms;

public partial class SliderPage : ContentPage
{
	public SliderPage()
	{
		InitializeComponent();
	}

    private void Slider_DragStarted(object sender, EventArgs e)
    {
        LblStatus.Text = "Arrastando";
    }

    private void Slider_DragCompleted(object sender, EventArgs e)
    {
        LblStatus.Text = "Arrastamento conclu�do";
    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        LblValue.Text = $"Valor selecionado: {e.NewValue}";
    }
}