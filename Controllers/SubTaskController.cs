using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using TaskApi.ITaskRepository;
using TaskApi.Models;

namespace TaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubTaskController : ControllerBase
    {
        ISubTask _repo;
        public SubTaskController(ISubTask _repo)
        {
            _repo = _repo;
        }

        // Add required dependencies here
        //[HttpGet]
        //public ActionResult<List<SubTask>> GetSubTasks()
        //{
        //    return Ok(_repo.GetAllSubTasks());
        //}

        [HttpGet("{id}")]
        public SubTask Get(int id) 
        {
            return _repo.GetSubTaskById(id);
        }

        [HttpPost]
        public void PostTask(SubTask subtask)
        {
            _repo.CreateSubTask(subtask);
        }


    }
}
