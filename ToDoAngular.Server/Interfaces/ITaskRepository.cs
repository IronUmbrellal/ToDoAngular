using ToDoAngular.Server.DataAccess;
namespace ToDoAngular.Server.Interfaces

{
    public interface ITaskRepository
    {
        Task<IEnumerable<ToDoTask>> GetAllTasksAsync();
        Task<ToDoTask?> GetTaskByIdAsync(int id);
        Task<ToDoTask> AddTaskAsync(ToDoTask task);
        Task UpdateTaskAsync (ToDoTask task);
        Task DeleteTaskAsync (int id);
    }
}
