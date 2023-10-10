using AppTask.Data.Models;
using AppTask.Database.Context;
using AppTask.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AppTask.Repositories;

public class TaskModelRepository : ITaskModelRepository
{
    private readonly AppTaskContext _context;

    public TaskModelRepository() 
        => _context = new AppTaskContext();

    public List<TaskModel> GetAll() 
        => _context.Tasks.OrderByDescending(x => x.PrevisionDate)
        .ToList();

    public TaskModel GetById(int id) 
        => _context.Tasks
            .Include(t => t.SubTasks)
            .FirstOrDefault(t => t.Id == id);

    public void Create(TaskModel task)
    {
        _context.Tasks.Add(task);
        _context.SaveChanges();
    }

    public void Update(TaskModel task)
    {
        _context.Tasks.Update(task);
        _context.SaveChanges();
    }

    public void Delete(TaskModel task)
    {
        var savedTask = GetById(task.Id);

        if (savedTask.SubTasks.Any())
            _context.SubTasks.RemoveRange(savedTask.SubTasks);

        _context.Tasks.Remove(savedTask);
        _context.SaveChanges();
    }
}
