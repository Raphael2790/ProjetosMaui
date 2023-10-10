namespace AppMAUIGallery.Views.Componentes.Forms;

public partial class CheckBoxPage : ContentPage
{
	public CheckBoxPage()
	{
		InitializeComponent();
	}

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		if(e.Value is true)
		{
			CheckBox checkBox = (CheckBox)sender;
			HorizontalStackLayout stack = (HorizontalStackLayout)checkBox.Parent;
			Label label = (Label)stack.Children[1];
			LblStatus.Text = $"Voc� escolheu a linguagem {label.Text}";
		}
		else
		{
			LblStatus.Text = "Voc� n�o escolheu nenhuma linguagem";
		}
    }
}