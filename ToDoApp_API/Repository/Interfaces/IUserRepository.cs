using System.Threading.Tasks;
using ToDoApp_API.Models;

namespace ToDoApp_API.Repository.Interfaces
{
    public interface IUserRepository
    {
        public void AddUser(User user);
        public User? GetUserByUserName(string username);
    }
}
