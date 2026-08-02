namespace ToDoAngular.Server.DataAccess
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public required string Email { get; set; } 
        public required string Password { get; set; }
        public DateOnly Birthday { get; set; }

        public ICollection<ToDoTask> ToDoTasks { get; set; } = new List<ToDoTask>();
    }
}
