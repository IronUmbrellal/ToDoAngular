using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoAngular.Server.DataAccess
{
    public class ToDoTask
    {
        public int Id { get; set; }
        public string? Title { get; set; } = null;
        public string? Description { get; set; }
        public bool isCompleted { get; set; } = false;
        
       public DateTime DueDate { get; set; } = DateTime.Now;
        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User? User { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category? Category { get; set; }

    }
}
