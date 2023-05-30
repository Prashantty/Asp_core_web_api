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

        ITask _repo;
        public TaskController(ITask repo)
        {
            _repo = repo;   
        }

        [HttpGet]
        public List<Tsk> GetTasks()
        {
            return _repo.GetAllTasks();
        }

        [HttpGet("{id}")]
        public Tsk GetTask(int id)
        {
            return _repo.GetTaskById(id);   
        }

        [HttpPost]
        public void PostTask(Tsk task)
        {
             _repo.CreateTask(task);  
        }

        [HttpPut("{id}")]
        public void EditTask(int id, Tsk tsk)
        {
            _repo.EditTask(id, tsk);

        }
        [HttpDelete("{id}")]

        public void DeleteClint(int id)
        {
            _repo.DeleteTask(id);
        }


    }
}
