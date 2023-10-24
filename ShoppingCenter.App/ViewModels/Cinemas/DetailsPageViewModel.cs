using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShoppingCenter.Models;

namespace ShoppingCenter.App.ViewModels.Cinemas;

[QueryProperty(nameof(Movie), "movie")]
public partial class DetailsPageViewModel : ObservableObject
{
    [ObservableProperty]
    private Movie movie;

    [RelayCommand]
    public async Task OnTapCloseGoToMoviesList(MediaElement player)
    {
        player.Stop();
        await Shell.Current.GoToAsync("..");
    }
}
