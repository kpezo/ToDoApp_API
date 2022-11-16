using Microsoft.Identity.Client;

namespace ToDoApp_API.Services.Authentication.Interfaces
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
