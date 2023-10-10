namespace AppMAUIGallery.Views.Animations;

public partial class BasicAnimations : ContentPage
{
	public BasicAnimations()
	{
		InitializeComponent();
	}

    private void Aumentar_Clicked(object sender, EventArgs e)
    {
		ImageBot.ScaleTo(2, 2000);
    }

    private void Diminuir_Clicked(object sender, EventArgs e)
    {
        ImageBot.ScaleTo(0.5, 2000);
    }

    private void Normal_Clicked(object sender, EventArgs e)
    {
        ImageBot.Scale = 1;
        ImageBot.TranslationX = 0;
        ImageBot.TranslationY = 0;
        ImageBot.Rotation = 0;
        ImageBot.Opacity = 1;
        ImageBot.ScaleX = 1;
        ImageBot.ScaleY = 1;
        ImageBot.RotationX = 0;
        ImageBot.RotationY = 0;
    }

    private void Mover_Clicked(object sender, EventArgs e)
    {
        ImageBot.TranslateTo(0, 90, 2000, Easing.BounceOut);
    }

    private async void Rotacionar_Clicked(object sender, EventArgs e)
    {
        //await ImageBot.RotateTo(360, 2000);
        //await ImageBot.RotateXTo(360, 2000);
        //await ImageBot.RotateYTo(360, 2000);
        await ImageBot.RelRotateTo(90, 2000);
    }

    private async void Transparecia_Clicked(object sender, EventArgs e)
    {
        await ImageBot.FadeTo(0.3, 2000);
    }

    private async void Sequencial_Clicked(object sender, EventArgs e)
    {
        await ImageBot.TranslateTo(100, 0, 250);
        await ImageBot.TranslateTo(-100, 0, 500);
        await ImageBot.TranslateTo(0, 0, 250);
    }

    private async void Simultaneo_Clicked(object sender, EventArgs e)
    {
        await Task.WhenAll(
                       ImageBot.TranslateTo(100, 0, 1000),
                                  ImageBot.RotateTo(360, 1000),
                                             ImageBot.FadeTo(0.6, 1000)
                                                    );
    }

    private void Cancelamento_Clicked(object sender, EventArgs e) 
        => ImageBot.CancelAnimations();

    private void Customizada_Clicked(object sender, EventArgs e)
    {   
        //Podemos encadear as animações ou disparar separadamente
        var principal = new Animation();
        var rotacao = new Animation(v => ImageBot.Rotation = v, 0, 360);
        var movimento = new Animation(v => ImageBot.TranslationX = v, 0, 100);
        var opacidade = new Animation(v => ImageBot.Opacity = v, 1, 0.5);

        principal.Add(0, 1, rotacao);
        principal.Add(0, 0.5, movimento);
        principal.Add(0, 0.5, opacidade);

        principal.Commit(this, "Customizada", 16, 10000);
        //rotacao.Commit(this, "CustomizadaRotacao", 16, 10000);
    }

    private void MudancaCor_Clicked(object sender, EventArgs e)
    {
        ImageBot.ColorTo(Colors.White, Colors.Violet, c => ImageBot.BackgroundColor = c, 2000);
    }
}