using System.Threading.Tasks;
using ToDoApp_API.Models;
using ToDoApp_API.Models.Request;
using ToDoApp_API.Models.Rresponse;

namespace ToDoApp_API.Services.Interfaces
{
    public interface ITodoService
    {
        void CreateTask(CreateTaskRequest task);
        Todo ReadTask(int id);
        void UpdateTask(UpdateTaskRequest utr);
        void DeleteTask(int id);
        List<TaskListResponse> GetAllTasks();
    }
}
