using ToDoApp_API.Models;

namespace ToDoApp_API.Services.Authentication.Interfaces
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);

    }
}
