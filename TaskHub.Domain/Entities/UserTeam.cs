using System.ComponentModel.DataAnnotations;

namespace TaskHub.Domain.Entities;

public class UserTeam : EntityBase
{
    [Required]
    public Guid UserId { get; set; }

    public User User { get; set; } = default!;

    [Required]
    public Guid TeamId { get; set; }

    public Team Team { get; set; } = default!;

    [MaxLength(50)]
    public string? Role { get; set; } // Ex: "Líder", "Membro", etc.

    public DateTime JoinedAt { get; set; } = DateTime.UtcNow;
}