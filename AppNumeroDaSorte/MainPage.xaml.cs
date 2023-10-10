namespace AppNumeroDaSorte;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnGenerateLuckyNumbers(object sender, EventArgs args)
	{
		AppName.IsVisible = false;
		LuckyNumbersContainer.IsVisible = true;

		var luckyNumbers = GenerateLuckyNumbers();

		LuckyNumber01.Text = luckyNumbers.ElementAt(0).ToString("D2");
		LuckyNumber02.Text = luckyNumbers.ElementAt(1).ToString("D2");
		LuckyNumber03.Text = luckyNumbers.ElementAt(2).ToString("D2");
		LuckyNumber04.Text = luckyNumbers.ElementAt(3).ToString("D2");
		LuckyNumber05.Text = luckyNumbers.ElementAt(4).ToString("D2");
		LuckyNumber06.Text = luckyNumbers.ElementAt(5).ToString("D2");
	}

	private static SortedSet<int> GenerateLuckyNumbers() 
	{
		var luckyNumbers = new SortedSet<int>();

        while (luckyNumbers.Count < 6)
            luckyNumbers.Add(Random.Shared.Next(1, 61));

        return luckyNumbers;
	}
}