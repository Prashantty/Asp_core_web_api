using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskApi.ITaskRepository;
using TaskApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        // Add required dependencies here

        ITask _repo1;
        public TaskController(ITask repo1)
        {
            _repo1= repo1;   
        }

        [Authorize]
        [HttpGet]
        public List<Tsk> GetTasks()
        {
            return _repo1.GetAllTasks();
        }

        [HttpGet("{id}")]
        public Tsk GetTask(int id)
        {
            return _repo1.GetTaskById(id);   
        }

        [HttpPost]
        public void PostTask(Tsk task)
        {
             _repo1.CreateTask(task);  
        }

        [HttpPut("{id}")]
        public void EditTask(int id, Tsk tsk)
        {
            _repo1.EditTask(id, tsk);

        }
        [HttpDelete("{id}")]

        public void DeleteClint(int id)
        {
            _repo1.DeleteTask(id);
        }

       



    }
}
