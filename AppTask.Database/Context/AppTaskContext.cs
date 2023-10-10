using AppTask.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AppTask.Database.Context;

public class AppTaskContext : DbContext
{
    public DbSet<TaskModel> Tasks { get; set; } = null!;
    public DbSet<SubTaskModel> SubTasks { get; set; } = null!;

    public AppTaskContext()
    {
        Database.Migrate();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "apptask.db");

        optionsBuilder.UseSqlite($"Filename={databasePath}");
    }
}
