using AppMVVMCommunityToolkit.Libraries.Messages;
using AppMVVMCommunityToolkit.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace AppMVVMCommunityToolkit.ViewModels;

public partial class PubSubPageViewModel : ObservableObject
{
    [ObservableProperty]
    private string inputMessage;

    [RelayCommand]
    private void SendText()
    {
        WeakReferenceMessenger.Default.Send(new TextMessage(InputMessage));
    }

    [RelayCommand]
    private void AddNewPerson()
    {
        var person = new Person
        {
            Name = "Pessoa criada na segunda tela",
            Email = "pessoa2@gmail.com"
        };

        WeakReferenceMessenger.Default.Send(new PersonMessage(person));
    }
}
