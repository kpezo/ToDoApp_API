using Microsoft.AspNetCore.Identity;

namespace ToDoApp_API.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int StatusId { get; set; }
        public Status? Status { get; set; }
        public int PriorityId { get; set; }
        public Priority? Priority { get; set; }
        public DateTime Duedate { get; set; }
        public Guid UsernameId { get; set; }
    }
}
