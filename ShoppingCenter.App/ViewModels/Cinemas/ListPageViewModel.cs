using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShoppingCenter.App.Services;
using ShoppingCenter.Models;

namespace ShoppingCenter.App.ViewModels.Cinemas;

public partial class ListPageViewModel : ObservableObject
{
    [ObservableProperty]
    private List<Movie> _movies;

    public ListPageViewModel()
    {
        var service = App.Current.Handler.MauiContext.Services.GetRequiredService<CinemaService>();
        _movies = service.GetMovies();
    }

    [RelayCommand]
    public async Task OnTapMovieGoToDetailPage(Movie movie)
    {
        var param = new Dictionary<string, object>
        {
            {"movie", movie }
        };

        if(DeviceInfo.Idiom == DeviceIdiom.Phone)
            await Shell.Current.GoToAsync("detail", param);
        else
            await Shell.Current.GoToAsync("detaildesktop", param);
    }
}
