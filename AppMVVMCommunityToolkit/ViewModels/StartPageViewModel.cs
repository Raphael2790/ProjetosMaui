using AppMVVMCommunityToolkit.Libraries.Messages;
using AppMVVMCommunityToolkit.Models;
using AppMVVMCommunityToolkit.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System.Collections.ObjectModel;

namespace AppMVVMCommunityToolkit.ViewModels;

public partial class StartPageViewModel : ObservableObject
{
    [ObservableProperty]
    private string message;

    [ObservableProperty]
    private Person person;

    public ObservableCollection<Person> People { get; set; }

    public StartPageViewModel()
    {
        Person = new Person();
        People = new ObservableCollection<Person>();

        WeakReferenceMessenger.Default.Register<TextMessage>(this, (r, m) =>
        {
            Message = m.Value;
        });

        WeakReferenceMessenger.Default.Register<PersonMessage>(this, (r, m) =>
        {
            People.Add(m.Value);
        });
    }

    [RelayCommand]
    public void Save()
    {
        People.Add(Person);
        Person = new Person();
    }

    [RelayCommand]
    public void GoToPubSubPage()
    {
        var navPage = (NavigationPage)App.Current.MainPage;
        navPage.PushAsync(new PubSubPage());
    }
}
