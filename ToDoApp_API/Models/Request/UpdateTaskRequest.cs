namespace ToDoApp_API.Models.Request
{
    public class UpdateTaskRequest
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int StatusId { get; set; }
        public int PriorityId { get; set; }
        public DateTime? Duedate { get; set; }
        public Guid UsernameId { get; set; }

    }
}
