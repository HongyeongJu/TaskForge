namespace TaskForge.Data
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get;set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        //Navigation properties
        public ICollection<Goal> Goals { get; set; } = new List<Goal>();
    }
}
