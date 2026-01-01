namespace BlazorTasks
{
    public class AppState
    {
        public string Theme { get; private set; } = "light";
        public event Action? OnChange;

        public void SetTheme(string theme)   
        {
            Theme = theme;
            OnChange?.Invoke();
        }
    }

}
