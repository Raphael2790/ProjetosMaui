using AppMVVM.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace AppMVVM.ViewModels;

public class StartPageViewModel : INotifyPropertyChanged
{
    private Person _person;

    public Person Person 
    { 
        get { return _person; } 
        set { _person = value; OnPropertyChanged(nameof(Person)); } 
    }

    public ICommand SaveCommand { get; set; }

    public ObservableCollection<Person> People { get; set; }

    public StartPageViewModel()
    {
        Person = new Person();
        SaveCommand = new Command(Save);
        People = new ObservableCollection<Person>();
    }

    private void Save(object obj)
    {
        People.Add(Person);
        Person = new Person();
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
