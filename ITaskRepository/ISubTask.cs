using TaskApi.Models;

namespace TaskApi.ITaskRepository
{
    public interface ISubTask
    {

        // Add a SubTack for a Task
        // Get all subtasks for a particular Task
        // Here in display Task Name, SubtTask Name,Created By, When


        public void CreateSubTask(SubTask subTask);

        public List<SubTask> GetAllSubTasks();

        public SubTask GetSubTaskById(int id);
    }
}
