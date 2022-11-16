using Microsoft.Identity.Client;

namespace ToDoApp_API.Services.Interfaces
{
    public interface IAuthenticationService
    {
        AuthenticationResult Register(
            string Username,
            string Password);

        AuthenticationResult Login(
            string Username,
            string Password);
    }

}
}
