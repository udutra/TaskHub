namespace TaskHub.Domain.Entities;

public class ActivityLog : EntityBase{
    public Guid UserId { get; set; }
    public User User { get; set; }
    public string Action { get; set; }
    public DateTime Timestamp { get; set; }
}