namespace AppMAUIGallery.Views.Componentes.Forms;

public partial class PickerPage : ContentPage
{
	public PickerPage()
	{
		InitializeComponent();
	}

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
		string brandName = (string)((Picker)sender).SelectedItem;

		lblMarca.Text = brandName;
    }
}