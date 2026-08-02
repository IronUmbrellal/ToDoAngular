namespace ToDoAngular.Server.DataAccess
{
    public class Category
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public ICollection<ToDoTask> ToDoTasks { get; set; } = new List<ToDoTask>();
       
    }
}
