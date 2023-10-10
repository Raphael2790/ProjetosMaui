using AppMAUIGallery.Repositories;

namespace AppMAUIGallery.Views;

public partial class Menu : ContentPage
{
    private readonly IGroupComponentRepository _groupComponentRepository;

	public Menu()
	{
		InitializeComponent();
        _groupComponentRepository = new GroupComponentRepository();
        
        MenuCollection.ItemsSource = _groupComponentRepository.GetGroupComponents();
	}

    private void OnTapComponent(object sender, TappedEventArgs e)
    {
        var page = (Type)e.Parameter;

        (App.Current.MainPage as FlyoutPage).Detail = new NavigationPage((Page)Activator.CreateInstance(page));
        (App.Current.MainPage as FlyoutPage).IsPresented = false;
    }

    private void OnTapHome(object sender, TappedEventArgs e)
    {
        (App.Current.MainPage as FlyoutPage).Detail = new AppMAUIGallery.Views.MainPage();
        (App.Current.MainPage as FlyoutPage).IsPresented = false;
    }
}