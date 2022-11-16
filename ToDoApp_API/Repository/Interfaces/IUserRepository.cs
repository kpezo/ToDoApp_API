using System.Threading.Tasks;
using ToDoApp_API.Models;

namespace ToDoApp_API.Repository.Interfaces
{
    public interface IUserRepository
    {

        public Task<User> Login(string username);
        public void Register(User user);
    }
}
