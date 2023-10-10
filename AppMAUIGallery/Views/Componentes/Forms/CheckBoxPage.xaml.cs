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
			LblStatus.Text = $"Você escolheu a linguagem {label.Text}";
		}
		else
		{
			LblStatus.Text = "Você não escolheu nenhuma linguagem";
		}
    }
}