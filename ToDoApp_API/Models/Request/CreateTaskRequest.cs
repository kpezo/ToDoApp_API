using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoApp_API.Models.Request
{
    public class CreateTaskRequest
    {
        public string Name { get; set; } = null!;
        public Guid UsernameId { get; set; }

    }
}
