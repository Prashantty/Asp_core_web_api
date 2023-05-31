using Microsoft.AspNetCore.Mvc;
using TaskApi.Context;
using TaskApi.ITaskRepository;
using TaskApi.Models;

namespace TaskApi.TaskRepository
{
    public class SubTaskRepo : ISubTask
    {

        TaskDbContext _db;
        public SubTaskRepo(TaskDbContext db)
        {
            _db = db;
        }
        public void CreateSubTask(SubTask subTask)
        {
            _db.SubTasks.Add(subTask);  
            _db.SaveChanges();

        }

        public List<SubTask> GetAllSubTasks()
        {

            var obj = _db.SubTasks.ToList();
            
            return obj;

        }

        public SubTask GetSubTaskById(int id)
        {

            var obj = _db.SubTasks.FirstOrDefault(x => x.Id == id);
            return obj;
        }
    }
}
