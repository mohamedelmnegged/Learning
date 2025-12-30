
using BlazorTasks.Models;

namespace BlazorTasks.Services
{
    public class TaskService
    {
        private readonly List<TodoTask> _tasks = new();
        private int _id = 1;

        public IReadOnlyList<TodoTask> GetTasks()
            => _tasks;

        public void AddTask(string title)
        {
            _tasks.Add(new TodoTask
            {
                Id = _id++,
                Title = title,
                IsCompleted = false
            });
        }

        public void Toggle(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                task.IsCompleted = !task.IsCompleted;
            }
        }
    }


}
