using AppMAUIGallery.Views.Lists.Models;

namespace AppMAUIGallery.Views.Lists;

public partial class ListViewPage : ContentPage
{
	public ListViewPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		ListViewControl.ItemsSource = MovieList.GetGroupList().Take(2);
    }

    private void ListViewControl_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var movie = e.SelectedItem as Movie;

        DisplayAlert("Filme selecionado!", $"O filme selecionado foi: {movie.Name}", "OK");
    }

    private async void ListViewControl_Refreshing(object sender, EventArgs e)
    {
        ListViewControl.IsRefreshing = true;
        await Task.Delay(3000);
        ListViewControl.ItemsSource = MovieList.GetGroupList();
        ListViewControl.IsRefreshing = false;
    }
}