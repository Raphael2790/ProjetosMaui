using AppTask.Data.Models;
using AppTask.Repositories;
using AppTask.Repositories.Interfaces;

namespace AppTask.Views;

public partial class StartPage : ContentPage
{
	private readonly ITaskModelRepository _taskModelRepository;
	private IList<TaskModel> _tasks;

	public StartPage()
	{
		InitializeComponent();

		_taskModelRepository = new TaskModelRepository();

		LoadData();
	}

	public void LoadData()
	{
		_tasks = _taskModelRepository.GetAll();
		CollectionViewTasks.ItemsSource = _tasks;
		LblEmptyText.IsVisible = !_tasks.Any();
	}

    private void OnButtonClickedToAdd(object sender, EventArgs e) 
		=> Navigation.PushModalAsync(new AddOrEditPage());

    private void OnBorderClickedToFocusEntry(object sender, TappedEventArgs e) 
		=> EntrySearch.Focus();

    private async void OnImageClickedToDelete(object sender, TappedEventArgs e)
    {
		var task = (TaskModel)e.Parameter;
		var confirm = await DisplayAlert("Confirmação exclusão!", $"Deseja excluir a tarefa: {task.Name}?", "Sim", "Não");

		if (confirm)
		{
			_taskModelRepository.Delete(task);
			LoadData();
		}
    }

    private void OnCheckBoxClickedToComplete(object sender, TappedEventArgs e)
    {
		var task = (TaskModel)e.Parameter;
		var checkBox = (CheckBox)sender;

		if (DeviceInfo.Platform != DevicePlatform.WinUI)
			checkBox.IsChecked = !checkBox.IsChecked;

		task.IsCompleted = checkBox.IsChecked;
		_taskModelRepository.Update(task);
    }

    private void OnStackLayoutClickedToEdit(object sender, TappedEventArgs e)
    {
		var task = (TaskModel)e.Parameter;
		Navigation.PushModalAsync(new AddOrEditPage(_taskModelRepository.GetById(task.Id)));
    }

    private void OnTextChanged_FilterList(object sender, TextChangedEventArgs e)
    {
		var word = e.NewTextValue;
		var filteredList = _tasks.Where(t => t.Name.ToLower().Contains(word.ToLower())).ToList();
		CollectionViewTasks.ItemsSource = filteredList;
    }
}