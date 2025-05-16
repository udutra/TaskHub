using System.ComponentModel.DataAnnotations;

namespace TaskHub.Domain.Entities;

public class User(string userName, string email, string fullName) : EntityBase{
    
    [Required, MaxLength(80)] 
    public string UserName { get; set; } = userName;
    
    [Required, EmailAddress, MaxLength(100)]
    public string Email { get; set; } = email;
    
    [Required, MaxLength(150)]
    public string FullName { get; set; } = fullName;
    
    public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    public ICollection<UserTeam> UserTeams { get; set; } = new List<UserTeam>();
}