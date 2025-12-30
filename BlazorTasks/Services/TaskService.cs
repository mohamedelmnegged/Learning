using BlazorTasks.Models;

namespace BlazorTasks.Services
{
    public class TaskService
    {
        private readonly HttpClient _http;

        public TaskService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<TodoTask>> GetTasksAsync()
            => await _http.GetFromJsonAsync<List<TodoTask>>("api/tasks") ?? new();

        public async Task AddTaskAsync(string title)
            => await _http.PostAsJsonAsync("api/tasks", title);

        public async Task ToggleAsync(int id)
            => await _http.PutAsync($"api/tasks/{id}/toggle", null);
    }
}
