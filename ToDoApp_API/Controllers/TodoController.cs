using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoApp_API.Models;
using ToDoApp_API.Models.Contracts;
using ToDoApp_API.Models.Request;
using ToDoApp_API.Services.Interfaces;

namespace ToDoApp_API.Controllers
{
    [Route("api")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;
        public TodoController(ITodoService todoService)
            => _todoService = todoService;


        [HttpPost("add")]
        public IActionResult CreateTask([FromBody] CreateTaskRequest task)
        {
            //if (!task.IsValid)
            //    => BadRequest(task.ErrorMessage);
            //try
            //{
            //    var createdTask = await _todoService.CreateTask(task);
            //    return Ok(createdTask);
            //}
            //catch(Exception ex)
            //{
            //    return BadRequest(ex.Message);
            //}

            _todoService.CreateTask(task);
            return Ok();
        }
        [HttpGet]
        [Route("get/{id}")]
        public IActionResult GetSingleTask(int id)
            => Ok(_todoService.ReadTask(id)); 
        
        [HttpGet]
        [Route("get")]
        public IActionResult GetAllTasks()
            => Ok(_todoService.GetAllTasks());

        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult DeleteTask(int id)
        {
            _todoService.DeleteTask(id);
            return NoContent();
        }


        //TODO dodat validaciju za maksimalne vrijednosti Name i Description
        [HttpPatch]
        [Route("update/{id}")]
        public IActionResult UpdateTask([FromRoute] int id, [FromBody] UpdateTaskRequest utr)
        {
            if (id != utr.Id)
            {
                return NotFound();
            }            
            _todoService.UpdateTask(utr);
            return Ok();
        }

    }
}
