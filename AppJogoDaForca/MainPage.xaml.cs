using AppJogoDaForca.Extensions;
using AppJogoDaForca.Models;
using AppJogoDaForca.Repositories;

namespace AppJogoDaForca;

public partial class MainPage : ContentPage
{
    private Word _word;
    private int _errors = 0;
    private const int MaxErrors = 6;

    public MainPage()
    {
        InitializeComponent();
        
        var repositoy = new WordRepository();
        _word = repositoy.GetRandomWord();

        LblTips.Text = _word.Tips;
        LblText.Text = new string('_', _word.Text.Length);
    }

    private async void OnButtonClicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        button.IsEnabled = false;
        var letter = button.Text[0];

        var positions = _word.Text.AllIndexesOf(letter.ToString());

        if (positions.Count == 0)
        {
            ErrorHandler(button);
            await IsGameOver();

            return;
        }

        ReplaceLetter(letter, positions);
        button.Style = App.Current.Resources.MergedDictionaries.ElementAt(1)["Success"] as Style;
        await HasWon();
    }

    #region Verify If Player Won
    private async Task HasWon()
    {
        if (!LblText.Text.Contains('_'))
        {
            await DisplayAlert("Parabéns!", "Você acertou a palavra!", "Novo Jogo");
            ResetScreen();
        }
    }

    private void ReplaceLetter(char letter, List<int> positions)
    {
        var text = LblText.Text.ToCharArray();

        foreach (var position in positions)
        {
            text[position] = letter;
        }

        LblText.Text = new string(text);
    }
    #endregion

    #region Verify Failed Attempts
    private void ErrorHandler(Button button)
    {
        _errors++;
        ImgMain.Source = ImageSource.FromFile($"forca{_errors + 1}.png");
        button.Style = App.Current.Resources.MergedDictionaries.ElementAt(1)["Fail"] as Style;
    }

    private async Task IsGameOver()
    {
        if (_errors is MaxErrors)
        {
            await DisplayAlert("Perdeu!", "Você foi enforcado!", "Novo Jogo");
            ResetScreen();
        }
    }
    #endregion

    #region Reset Screen To Initial State
    private void ResetScreen()
    {
        ResetVirtualKeyboard();
        ResetErrors();
        GenerateNewRandomWord();
    }

    private void GenerateNewRandomWord()
    {
        var repositoy = new WordRepository();
        _word = repositoy.GetRandomWord();

        LblText.Text = new string('_', _word.Text.Length);
        LblTips.Text = _word.Tips;
    }

    private void ResetErrors()
    {
        _errors = 0;
        ImgMain.Source = ImageSource.FromFile($"forca1.png");
    }

    private void ResetVirtualKeyboard()
    {
        ResetVirtualLines((HorizontalStackLayout)KeyBoardContainer.Children[0]);
        ResetVirtualLines((HorizontalStackLayout)KeyBoardContainer.Children[1]);
        ResetVirtualLines((HorizontalStackLayout)KeyBoardContainer.Children[2]);
    }

    private void ResetVirtualLines(HorizontalStackLayout layout)
    {
        foreach (Button button in layout.Cast<Button>())
        {
            button.IsEnabled = true;
            button.Style = null;
        }
    }
    #endregion

    private void OnResetButtonClicked(object sender, EventArgs e) 
        => ResetScreen();
}