using ToDoApp_API.Models;

namespace ToDoApp_API.Services.Authentication
{
    public record AuthenticationResult(
        User User,
        string Token);
}
