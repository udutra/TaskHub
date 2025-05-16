using System.ComponentModel.DataAnnotations;

namespace TaskHub.Domain.Entities;

public class Category : EntityBase{
    
    [Required, MaxLength(50)]
    public string Name { get; set; }
    
    [MaxLength(500)]
    public string? Description { get; set; }

    public ICollection<TaskItem> Tasks { get; set; }
}