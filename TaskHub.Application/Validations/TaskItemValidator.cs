using FluentValidation;
using TaskHub.Domain.Entities;

namespace TaskHub.Application.Validations;

public class TaskItemValidator : AbstractValidator<TaskItem>{
    public TaskItemValidator(){
        RuleFor(t => t.Title)
            .NotEmpty().WithMessage("O título é obrigatório.")
            .MaximumLength(100);

        RuleFor(t => t.Description)
            .MaximumLength(500);

        RuleFor(t => t.DueDate)
            .GreaterThan(DateTime.UtcNow)
            .When(t => t.DueDate.HasValue)
            .WithMessage("A data de entrega deve ser futura.");

        RuleFor(t => t.UserId)
            .NotEmpty().WithMessage("Usuário é obrigatório.");

        RuleFor(t => t.Status)
            .IsInEnum().WithMessage("Status inválido.");
    }
}