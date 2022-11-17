using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoApp_API.Models.Contracts;
using ToDoApp_API.Services.Authentication.Interfaces;

namespace ToDoApp_API.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request)
        {
            var authResult = _authenticationService.Register(
                request.UserName,
                request.Password);
            
            var response = new AuthenticationResponse(
                authResult.User.Id,
                authResult.User.UserName,
                authResult.Token);

            return Ok(response);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            var authResult = _authenticationService.Login(
                            request.UserName,
                            request.Password);

            var response = new AuthenticationResponse(
                authResult.User.Id,
                authResult.User.UserName,
                authResult.Token);

            return Ok(response);
        }
    }

}

