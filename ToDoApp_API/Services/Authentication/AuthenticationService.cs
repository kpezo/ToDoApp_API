using ToDoApp_API.Models;
using ToDoApp_API.Repository.Interfaces;
using ToDoApp_API.Services.Authentication.Interfaces;

namespace ToDoApp_API.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepository;

        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userRepository = userRepository;
        }

        public AuthenticationResult Register(string username, string password)
        {

            //1. Validate that the user does not exists
            if (_userRepository.GetUserByUserName(username) is not null)
            {
                throw new Exception("Email already exists");
            }
            //2. Create user(generate unique ID) & Persist to DB
            var user = new User
            {
                UserName = username,
                Password = password
            };

            _userRepository.AddUser(user);

            //3. Create JWT token

            var token = _jwtTokenGenerator.GenerateToken(user);


            return new AuthenticationResult(
                user,
                token);
        }

        public AuthenticationResult Login(string username, string password)
        {
            //1. Validate that the user exists
            if (_userRepository.GetUserByUserName(username) is not User user)
            {
                throw new Exception("User with given email does not exist.");
            }

            //2. Validate that the password is correct
            if (user.Password != password)
            {
                throw new Exception("Invalid password.");
            }

            //3. Create JWT token and return to the user
            var token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthenticationResult(
                user,
                token);
        }
    }
}
