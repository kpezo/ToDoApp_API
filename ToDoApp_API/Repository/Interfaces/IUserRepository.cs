using System.Threading.Tasks;
using ToDoApp_API.Models;

namespace ToDoApp_API.Repository.Interfaces
{
    public interface IUserRepository
    {
        public User? GetUserByUsername(string username);
        public void AddUser(User user);
    }
}
