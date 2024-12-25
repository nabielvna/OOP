namespace Solution.Extra
{
    public class Task
    {
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public Task(string description)
        {
            Description = description;
            IsCompleted = false;
        }

        public override string ToString()
        {
            return $"{Description} - {(IsCompleted ? "Completed" : "Pending")}";
        }
    }

    public class TaskManager
    {
        private List<Task> tasks;

        public TaskManager()
        {
            tasks = new List<Task>();
        }

        public void AddTask(string description)
        {
            tasks.Add(new Task(description));
        }

        public void CompleteTask(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks[index].IsCompleted = true;
            }
        }

        public List<Task> GetAllTasks()
        {
            return tasks;
        }
    }
}