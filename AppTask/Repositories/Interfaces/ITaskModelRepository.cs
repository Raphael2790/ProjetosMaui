using AppTask.Data.Models;

namespace AppTask.Repositories.Interfaces;

public interface ITaskModelRepository
{
    List<TaskModel> GetAll();
    TaskModel GetById(int id);
    void Create(TaskModel task);
    void Update(TaskModel task);
    void Delete(TaskModel task);
}
