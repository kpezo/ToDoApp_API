namespace ToDoApp_API.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
