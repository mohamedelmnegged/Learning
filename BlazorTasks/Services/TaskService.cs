
namespace BlazorTasks.Services
{
    public class TaskService
    {
        private readonly List<string> _tasks = new();

        public List<string> GetTasks() => _tasks;

        public void AddTask(string task)
        {
            _tasks.Add(task);
        }
    }

}
