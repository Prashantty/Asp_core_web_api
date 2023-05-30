using TaskApi.Models;

namespace TaskApi.ITaskRepository
{
    public interface ITask
    {
        //Declare all following functions only for CRUD for Task & SubTask

        // Add a Task
        // Get all Tasks
        // Get a particular Task
        // Edit some Task
        // Delete some task, in case there is no subtask

        public void CreateTask(Tsk task);
        public List<Tsk> GetAllTasks();

        public Tsk GetTaskById(int id);

        public void EditTask(int id, Tsk task);
        public void DeleteTask(int id);


       



    }
}
