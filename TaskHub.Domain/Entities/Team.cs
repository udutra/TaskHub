using System.ComponentModel.DataAnnotations;

namespace TaskHub.Domain.Entities;

public class Team(string name) : EntityBase
{
    [Required, MaxLength(100)]
    public string Name { get; set; } = name;
    
    public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    public ICollection<UserTeam> UserTeams { get; set; } = new List<UserTeam>();
    
    
}