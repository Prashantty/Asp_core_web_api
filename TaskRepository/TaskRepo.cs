using Microsoft.AspNetCore.Routing.Template;
using TaskApi.Context;
using TaskApi.ITaskRepository;
using TaskApi.Models;

namespace TaskApi.TaskRepository
{
    public class TaskRepo : ITask
    {
        TaskDbContext _db;
        public TaskRepo(TaskDbContext db)
        {
            _db = db; 
        }

        public void CreateTask(Tsk task)
        {
            _db.Tasks.Add(task);        
            _db.SaveChanges();  
        }

        public void DeleteTask(int id)
        {
            Tsk tsk = _db.Tasks.FirstOrDefault(t => t.Id == id);    
            if (tsk != null)
            {
                _db.Tasks.Remove(tsk);
                _db.SaveChanges();
            }
        }

        public void EditTask(int id, Tsk task)
        {
            Tsk tsk = _db.Tasks.FirstOrDefault(x => x.Id == id);
            if(tsk != null)
            {
                foreach(Tsk temp in _db.Tasks)
                {
                    temp.Name = task.Name;  
                    temp.Description = task.Description;
                    temp.CreatedBy = task.CreatedBy;
                    temp.CreatedOn = task.CreatedOn;    

                }
               
            }
            _db.Tasks.Update(tsk);
        }

        public List<Tsk> GetAllTasks()
        {
            return _db.Tasks.ToList();
        }

        public Tsk GetTaskById(int id)
        {
            return _db.Tasks.FirstOrDefault(x => x.Id == id);
        }
      
    }
}
