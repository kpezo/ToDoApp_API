using ToDoApp_API.Models;

namespace ToDoApp_API.Services
{
    public record AuthenticationResult(
        User User,
        string Token);
}
