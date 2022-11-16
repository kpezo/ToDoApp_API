namespace ToDoApp_API.Models.Contracts
{
    public record RegisterRequest(
        string UserName,
        string Password);
}
