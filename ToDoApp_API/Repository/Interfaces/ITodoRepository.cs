using ToDoApp_API.Models;
using ToDoApp_API.Models.Request;

namespace ToDoApp_API.Repository.Interfaces
{
    public interface ITodoRepository
    {
        void CreateTask(CreateTaskRequest task);
        Task<List<Todo>> GetAllTasks();
        Task<Todo> ReadTask(int id);
        void DeleteTask(int id);
        void UpdateTodo(UpdateTaskRequest utr);

    }
}
