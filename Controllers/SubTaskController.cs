using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskApi.Context;
using TaskApi.ITaskRepository;
using TaskApi.Models;

namespace TaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubTaskController : ControllerBase
    {

        ISubTask _repo;
        TaskDbContext _db;
        public SubTaskController(ISubTask _repo , TaskDbContext db)
        {
            _repo = _repo;
            _db = db;
        }


        //  add required dependencies here
        [HttpGet]
        public ActionResult<List<SubTask>> getSubTask()
        {
            if(_db.SubTasks.ToList().Count == 0)
            {
                 return NotFound();
            }
            return Ok(_repo.GetAllSubTasks());
        }

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