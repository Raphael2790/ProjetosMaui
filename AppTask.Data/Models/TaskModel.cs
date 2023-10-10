﻿using System.Collections.ObjectModel;
using System.ComponentModel;

namespace AppTask.Data.Models;

public class TaskModel : INotifyPropertyChanged
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime PrevisionDate { get; set; }

    private bool _isCompleted;
    public bool IsCompleted 
    { 
        get 
        {
            return _isCompleted;
        } 
        set 
        {
            _isCompleted = value;
            OnPropertyChanged(nameof(IsCompleted));
        } 
    }

    public DateTime CreationDate { get; set; }
    public DateTime? Updated { get; set; }

    public ObservableCollection<SubTaskModel> SubTasks { get; set; } = new ObservableCollection<SubTaskModel>();

    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged(string propertyName) 
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
