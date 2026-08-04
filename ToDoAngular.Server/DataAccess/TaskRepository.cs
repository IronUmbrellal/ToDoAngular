using ToDoAngular.Server.DataAccess;
using Microsoft.EntityFrameworkCore;
using ToDoAngular.Server.Interfaces;
namespace ToDoAngular.Server.DataAccess

{
    public class TaskRepository : ITaskRepository
    {
        private readonly AppDbContext _context;
        public TaskRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ToDoTask>> GetAllTasksAsync()
        {
            return await _context.ToDoTasks.ToListAsync();
        }

        public async Task<ToDoTask?> GetTaskByIdAsync(int id)
        {
            return await _context.ToDoTasks.FindAsync(id);
        }

        public async Task<ToDoTask> AddTaskAsync(ToDoTask task)
        {
            _context.ToDoTasks.Add(task);
            await _context.SaveChangesAsync();
            return task;
        }

        public async Task UpdateTaskAsync(ToDoTask task)
        {
            _context.ToDoTasks.Update(task);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTaskAsync(int id)
        {
            var task = await _context.ToDoTasks.FindAsync(id);
            if (task != null)
            {
                _context.ToDoTasks.Remove(task);
                await _context.SaveChangesAsync();
            }
        }
    }
}
