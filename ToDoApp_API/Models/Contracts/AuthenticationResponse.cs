namespace ToDoApp_API.Models.Contracts
{
    public record AuthenticationResponse(
        Guid Id,
        string UserName,
        string Token);
}
