using System.Diagnostics;

namespace TaskForge.Data
{
    public class Goal
    {

        public Guid GoalId { get; set; }

        public Guid? UserId { get; set; }

        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public PriorityLevel Priority { get; set; } = PriorityLevel.Medium;
        public DateTime? Deadline { get; set; }
        public GoalStatus Status { get; set; } = GoalStatus.NotStarted;
        public string? Category { get; set; }  
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        //Navigation properties
        public User? User { get; set; }
        public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    }
}
