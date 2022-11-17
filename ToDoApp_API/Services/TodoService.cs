using AutoMapper;
using System.Threading.Tasks;
using ToDoApp_API.Models;
using ToDoApp_API.Models.Request;
using ToDoApp_API.Models.Rresponse;
using ToDoApp_API.Repository.Interfaces;
using ToDoApp_API.Services.Interfaces;

namespace ToDoApp_API.Services
{
    public class TodoService : ITodoService
    {
        private ITodoRepository _todoRepository;
        private IMapper _mapper;

        public TodoService(ITodoRepository todoRepository, IMapper mapper)
        {
            _todoRepository = todoRepository;
            _mapper = mapper;
        }
        public void CreateTask(CreateTaskRequest task)
            => _todoRepository.CreateTask(task);

        public Todo ReadTask(int id)
            => _todoRepository.ReadTask(id).Result;
        public void UpdateTask(UpdateTaskRequest utr)
        {
            _todoRepository.UpdateTodo(utr);
        }
        public void DeleteTask(int id)
        {
            _todoRepository.DeleteTask(id);
        }

        public List<TaskListResponse> GetAllTasks()
        {
            var todoList = _todoRepository.GetAllTasks().Result;
            var taskList = _mapper.Map<List<TaskListResponse>>(todoList);
            return taskList;
        }
        

        

    }
}
