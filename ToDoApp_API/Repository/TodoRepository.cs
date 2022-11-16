using Microsoft.EntityFrameworkCore;
using ToDoApp_API.DatabaseContext;
using ToDoApp_API.Models;
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
        public async void AddTodo(Todo todo)
        {
            _dbContext.Set<Todo>().Add(todo);
            await _dbContext.SaveChangesAsync();
        }

        public void DeleteTodoById(int id)
        {
            var todo = _dbContext.Todo.FirstOrDefaultAsync(x=> x.Id== id).Result;
            
            if (todo is not null)
            {
                _dbContext.Set<Todo>().Remove(todo);
            }
        }
        public async Task<List<Todo>> GetAllTodos()
        {
            return await _dbContext.Set<Todo>().ToListAsync();
        }

        public async Task<Todo> GetTodoById(int id)
        {
            var todoDto = await _dbContext.Set<Todo>().FirstOrDefaultAsync(x => x.Id == id) ?? new Todo();
            return todoDto;
        }

        public async void UpdateTodo(Todo todo)
        {
            var updateTodo = await _dbContext.Set<Todo>().FirstOrDefaultAsync(x => x.Id == todo.Id);

            if (updateTodo is not null)
            {
                updateTodo.Name = todo.Name;
                updateTodo.Description = todo.Description;
                updateTodo.PriorityId = todo.PriorityId;
                updateTodo.StatusId = todo.StatusId;
                updateTodo.Duedate = todo.Duedate;
            }

        }
    }
}
