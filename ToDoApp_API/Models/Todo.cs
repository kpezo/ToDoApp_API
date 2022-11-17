using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoApp_API.Models
{
    public class Todo
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(80)")]

        public string Name { get; set; } = null!;
        [Column(TypeName = "varchar(280)")]
        public string Description { get; set; } = null!;
        public int StatusId { get; set; }
        public Status? Status { get; set; }
        public int PriorityId { get; set; }
        public Priority? Priority { get; set; }
        public DateTime? Duedate { get; set; }
        public Guid UsernameId { get; set; }
    }
}
