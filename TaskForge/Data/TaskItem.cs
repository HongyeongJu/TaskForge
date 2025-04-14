namespace TaskForge.Data
{
    public class TaskItem
    {
        public Guid TaskItemId { get; set; }

        public Guid? GoalId { get; set; }

        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public PriorityLevel Priority { get; set; } = PriorityLevel.Medium;
        public DateTime? Deadline { get; set; }
        public TaskStatus Status { get; set; } = TaskStatus.NotStarted;
        public bool Isnotified { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation Properties
        public Goal? Goal { get; set; }
    }
}
