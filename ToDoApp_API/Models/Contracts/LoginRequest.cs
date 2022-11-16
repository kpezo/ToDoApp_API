namespace ToDoApp_API.Models.Contracts
{
    public record LoginRequest(
        string UserName,
        string Password);
}
