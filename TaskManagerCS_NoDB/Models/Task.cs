namespace TaskManagerCS.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TaskProgress { get; set; }
        public string Priority { get; set; }
        public int UserId { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsTrashed { get; set; }
        public string TaskType { get; set; } 
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public Task(int id, string taskName, string taskProgress, string priority, int userId, DateTime dueDate, bool isTrashed = false, string taskType = "To-Do", DateTime? startTime = null, DateTime? endTime = null)
        {
            Id = id;
            TaskName = taskName;
            TaskProgress = taskProgress;
            Priority = priority;
            UserId = userId;
            DueDate = dueDate;
            IsTrashed = isTrashed;
            TaskType = taskType;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
