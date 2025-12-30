using BlazorTasks.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorTasks.Api.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    public class TasksController : ControllerBase
    {
        private static readonly List<TodoTask> Tasks = new();
        private static int _id = 1;

        [HttpGet]
        public IActionResult Get()
            => Ok(Tasks);

        [HttpPost]
        public IActionResult Create([FromBody] string title)
        {
            var task = new TodoTask
            {
                Id = _id++,
                Title = title
            };

            Tasks.Add(task);
            return Ok(task);
        }

        [HttpPut("{id}/toggle")]
        public IActionResult Toggle(int id)
        {
            var task = Tasks.FirstOrDefault(t => t.Id == id);
            if (task == null) return NotFound();

            task.IsCompleted = !task.IsCompleted;
            return Ok(task);
        }
    }

}
