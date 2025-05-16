using FluentValidation;
using TaskHub.Domain.Entities;

namespace TaskHub.Application.Validations;

public class TeamValidator : AbstractValidator<Team>
{
    public TeamValidator()
    {
        RuleFor(t => t.Name)
            .NotEmpty().WithMessage("O nome da equipe é obrigatório.")
            .MaximumLength(100);
    }
}