using AppMAUIGallery.Views.Lists.Models;
using System.Collections.ObjectModel;
using System.Text;

namespace AppMAUIGallery.Views.Lists;

public partial class CollectionViewPage : ContentPage
{
	//Precisa ser uma coleção observável para que a lista seja atualizada
	private readonly ObservableCollection<Movie> _movies = new();
	private int _movieCount = 0;

	public CollectionViewPage()
	{
		InitializeComponent();

		AddTwentyMovies();

		CollectionViewControl.ItemsSource = MovieList.GetGroupList();
	}

    private async void RefreshView_Refreshing(object sender, EventArgs e)
    {
		((RefreshView)sender).IsRefreshing = true;

		await Task.Delay(3000);
		CollectionViewControl.ItemsSource = MovieList.GetList();

		((RefreshView)sender).IsRefreshing = false;
    }

    private void CollectionViewControl_RemainingItemsThresholdReached(object sender, EventArgs e) 
		=> AddTwentyMovies();

    private void AddTwentyMovies()
	{
		for (int i = 0; i < 20; i++)
		{
            _movies.Add(new Movie
			{
				Id = _movieCount++,
                Name = $"Movie {_movieCount}",
                Description = $"Description {_movieCount}",
				Duration = new TimeSpan(2, 0, 0),
				LaunchYear = 2021,
            });
        }
	}

    private void CollectionViewControl_Scrolled(object sender, ItemsViewScrolledEventArgs e)
    {
		LblSrollStatus.Text = $"Posicionamento: {e.VerticalOffset} - Espaçamento: {e.VerticalDelta}";

		if(DeviceInfo.Platform != DevicePlatform.WinUI)
			return;

		if(sender is CollectionView cv)
		{
			var lastVisibleItem = e.LastVisibleItemIndex;
			var remainningItemsThreshold = cv.RemainingItemsThreshold;
			var totalItemsCount = cv.ItemsSource.Cast<object>().Count();

			if(lastVisibleItem + remainningItemsThreshold >= totalItemsCount)
                AddTwentyMovies();
		}
    }

    private void CollectionViewControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
		var builder = new StringBuilder();

		foreach (var item in e.CurrentSelection)
		{
			   if(item is Movie movie)
				builder.AppendLine(movie.Name + "-");
		}

		LblSelectedMovies.Text = builder.ToString();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		var group = (List<GroupMovie>)CollectionViewControl.ItemsSource;
		var item = group[2][0];

		//ScrollTo pode ser feito por indice ou por item 
		CollectionViewControl.ScrollTo(item, group[2], ScrollToPosition.Center, true);
    }
}