using AppMAUIGallery.Libraries;
using AppMAUIGallery.Models;
using AppMAUIGallery.Repositories;
using System.Collections.ObjectModel;

namespace AppMAUIGallery.Views;

public partial class MainPage : ContentPage
{
    private readonly IGroupComponentRepository _groupComponentRepository;
    private List<Components> _fullList;
    private ObservableCollection<Components> _filteredList;

	public MainPage()
	{
		InitializeComponent();

        _groupComponentRepository = new GroupComponentRepository();

        _fullList = _groupComponentRepository.GetComponents();

        _filteredList = new ObservableCollection<Components>(_fullList);

        ComponentCollection.ItemsSource = _filteredList;
	}

    private void OnTapComponent(object sender, TappedEventArgs e)
    {
        KeyboardFix.HideKeyboard();

        var page = (Type)e.Parameter;

        (App.Current.MainPage as FlyoutPage).Detail = new NavigationPage((Page)Activator.CreateInstance(page));
        (App.Current.MainPage as FlyoutPage).IsPresented = false;
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        var word = e.NewTextValue.ToLower();

        Clear();
        Search(word);
    }

    public void Clear()
    {
        var limit = _filteredList.Count;

        for (int i = 0; i < limit; i++)
        {
            _filteredList.RemoveAt(0);
        }
    }

    private void Search(string word)
    {
        var filteredList = _fullList.Where(x => x.Title.ToLower().Contains(word)).ToList();

        foreach (var item in filteredList)
        {
            _filteredList.Add(item);
        }
    }
}