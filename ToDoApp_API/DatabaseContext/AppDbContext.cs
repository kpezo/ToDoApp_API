using Microsoft.EntityFrameworkCore;
using ToDoApp_API.Models;

namespace ToDoApp_API.DatabaseContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
        public DbSet<TodoList> TodoLists { get; set; }
        public DbSet<Priority> Priority { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
