using System.Windows.Input;

namespace AppMAUIGallery.Views.CommunityMaui.ViewModel;

public class CommunityBehaviorsPageViewModel
{
    public ICommand PressedCommand { get; set; }

    public CommunityBehaviorsPageViewModel()
    {
        PressedCommand = new Command(Pressed);
    }

    private void Pressed()
    {
        App.Current.MainPage.DisplayAlert("Alerta", "Você pressionou o botão!", "OK");
    }
}
