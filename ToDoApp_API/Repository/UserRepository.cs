using Microsoft.EntityFrameworkCore;
using ToDoApp_API.DatabaseContext;
using ToDoApp_API.Models;
using ToDoApp_API.Repository.Interfaces;

namespace ToDoApp_API.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;
        public UserRepository(AppDbContext dbContext)
            => _dbContext = dbContext;

        public async void AddUser(User user)
        {
            _dbContext.Set<User>().Add(user);
            await _dbContext.SaveChangesAsync();
        }

        public User? GetUserByUsername(string username)
            => _dbContext.Set<User>().FirstOrDefaultAsync(x=>x.Username== username);
    }
}
