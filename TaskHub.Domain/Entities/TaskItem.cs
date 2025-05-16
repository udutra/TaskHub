using System.ComponentModel.DataAnnotations;
using TaskHub.Domain.Enums;

namespace TaskHub.Domain.Entities;

public class TaskItem : EntityBase{

    [Required, MaxLength(100)]
    public string Title { get; set; }

    [MaxLength(500)]
    public string? Description { get; set; }

    [Required]
    public TaskStatusEnum Status { get; set; } = TaskStatusEnum.Pending;
    public DateTime? DueDate { get; set; }

    [Required]
    public Guid UserId { get; set; }
    public User User { get; set; }
    public Guid? CategoryId { get; set; }
    public Category? Category { get; set; }
    public Guid? TeamId { get; set; }
    public Team? Team { get; set; }
    public ICollection<Comment> Comments { get; set; }
}