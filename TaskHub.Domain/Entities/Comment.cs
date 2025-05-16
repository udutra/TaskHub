using System.ComponentModel.DataAnnotations;

namespace TaskHub.Domain.Entities;

public class Comment : EntityBase
{
    [Required, MaxLength(1000)]
    public string Content { get; set; }

    [Required]
    public Guid TaskItemId { get; set; }

    public TaskItem TaskItem { get; set; }

    [Required]
    public Guid UserId { get; set; }

    public User User { get; set; }
}