using AppTask.Data.Models;
using AppTask.Repositories;
using AppTask.Repositories.Interfaces;

namespace AppTask.Views;

public partial class AddOrEditPage : ContentPage
{
    private TaskModel _task;
    private readonly ITaskModelRepository _taskModelRepository;

	public AddOrEditPage()
	{
		InitializeComponent();
        _task = new TaskModel();
        _taskModelRepository = new TaskModelRepository();
        BindableLayout.SetItemsSource(BindableLayout_Steps, _task.SubTasks);
	}

    public AddOrEditPage(TaskModel task)
    {
        _taskModelRepository = new TaskModelRepository();
        InitializeComponent();
        _task = task;
        FillFields();

        BindableLayout.SetItemsSource(BindableLayout_Steps, _task.SubTasks);
    }

    private void FillFields()
    {
        EntryTaskName.Text = _task.Name;
        EditorTaskDescription.Text = _task.Description;
        DatePickerTaskDate.Date = _task.PrevisionDate;
    }

    private async void AddStep(object sender, EventArgs e)
    {
        var stepName = await DisplayPromptAsync("Etapa(subtarefa)", "Digite o nome da etapa(subtarefa)", "Adicionar", "Cancelar");

        if (!string.IsNullOrEmpty(stepName))
        {
            _task.SubTasks.Add(new SubTaskModel { Name = stepName, IsCompleted = false });
        }
    }

    private void SaveData(object sender, EventArgs e)
    {
        GetDataFromForm();
        if (ValidateData())
        {
            PersistData();
            Navigation.PopModalAsync();
            UpdateStartPage();
        }

    }

    private void UpdateStartPage()
    {
        var navPage = (NavigationPage)Application.Current.MainPage;
        var startPage = (StartPage)navPage.CurrentPage;
        startPage.LoadData();
    }

    private void PersistData()
    {
        if (_task.Id > 0)
            _taskModelRepository.Update(_task);
        else
            _taskModelRepository.Create(_task);
    }

    private bool ValidateData()
    {
        bool resultIsValid = true;
        EditorTaskNameRequired.IsVisible = false;
        EntryTaskNameRequired.IsVisible = false;

        if (string.IsNullOrEmpty(_task.Name))
        {
            resultIsValid = false;
            EntryTaskNameRequired.IsVisible = true;
        }

        if (string.IsNullOrWhiteSpace(_task.Description))
        {
            resultIsValid = false;
            EditorTaskNameRequired.IsVisible = true;
        }

        return resultIsValid;
    }

    private void GetDataFromForm()
    {
        _task.Name = EntryTaskName.Text;
        _task.Description = EditorTaskDescription.Text;
        _task.PrevisionDate = DatePickerTaskDate.Date;
        _task.PrevisionDate = _task.PrevisionDate.AddHours(23);
        _task.PrevisionDate = _task.PrevisionDate.AddMinutes(59);
        _task.PrevisionDate = _task.PrevisionDate.AddSeconds(59);

        _task.CreationDate = DateTime.Now;
        _task.IsCompleted = false;
    }

    private void CloseModal(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);

        DatePickerTaskDate.WidthRequest = width - 30;
    }

    private void RemoveStep(object sender, TappedEventArgs e)
    {
        _task.SubTasks.Remove((SubTaskModel)e.Parameter);
    }
}