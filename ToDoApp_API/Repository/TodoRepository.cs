using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoApp_API.DatabaseContext;
using ToDoApp_API.Models;
using ToDoApp_API.Models.Request;
using ToDoApp_API.Repository.Interfaces;

namespace ToDoApp_API.Repository
{
    public class TodoRepository : ITodoRepository
    {
        private readonly AppDbContext _dbContext;

        public TodoRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void CreateTask(CreateTaskRequest task)
        {
            var todo = new Todo {
                Name = task.Name,
                StatusId = 1,
                PriorityId = 1,
                Description = "",
                UsernameId = task.UsernameId
            };

            _dbContext.Set<Todo>().Add(todo);
            _dbContext.SaveChanges();


        }

        public void DeleteTask(int id)
        {
            var todo = _dbContext.Todo.FirstOrDefaultAsync(x=> x.Id== id).Result;
            
            if (todo is not null)
            {
                _dbContext.Set<Todo>().Remove(todo);
                _dbContext.SaveChanges();

            }
        }
        public async Task<List<Todo>> GetAllTasks()
        {
            return await _dbContext.Set<Todo>().ToListAsync();
        }

        public async Task<Todo> ReadTask(int id)
        {
            var todo = await _dbContext.Set<Todo>().FirstOrDefaultAsync(x => x.Id == id) ?? new Todo();

            return todo;
        }

        public void UpdateTodo(UpdateTaskRequest utr)
        {
            var updateTodo = new Todo();
            updateTodo = _dbContext.Set<Todo>().FirstOrDefaultAsync(x => x.Id == utr.Id).Result;

            if (updateTodo is not null)
            {
                updateTodo.Name = utr.Name;
                updateTodo.Description = utr.Description;
                updateTodo.PriorityId = utr.PriorityId;
                updateTodo.StatusId = utr.StatusId;
                updateTodo.Duedate = utr.Duedate;
            }
            await _dbContext.SaveChangesAsync();

        }
    }
}
