using ToDoApp_API.Models;

namespace ToDoApp_API.Repository.Interfaces
{
    public interface ITodoRepository
    {
        Task<List<Todo>> GetAllTodos();
        Task<Todo> GetTodoById(int id);
        void DeleteTodoById(int id);
        void UpdateTodo(Todo todo);

    }
}
