using FluentValidation;
using TaskHub.Domain.Entities;

namespace TaskHub.Application.Validations;

public class UserTeamValidator : AbstractValidator<UserTeam>
{
    public UserTeamValidator()
    {
        RuleFor(ut => ut.UserId)
            .NotEmpty().WithMessage("Usuário é obrigatório.");

        RuleFor(ut => ut.TeamId)
            .NotEmpty().WithMessage("Equipe é obrigatória.");

        RuleFor(ut => ut.Role)
            .MaximumLength(50);

        RuleFor(ut => ut.JoinedAt)
            .LessThanOrEqualTo(DateTime.UtcNow)
            .WithMessage("A data de entrada não pode estar no futuro.");
    }
}