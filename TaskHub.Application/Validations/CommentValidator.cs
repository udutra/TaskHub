using FluentValidation;
using TaskHub.Domain.Entities;

namespace TaskHub.Application.Validations;

public class CommentValidator : AbstractValidator<Comment>
{
    public CommentValidator()
    {
        RuleFor(c => c.Content)
            .NotEmpty().WithMessage("O conteúdo do comentário é obrigatório.")
            .MaximumLength(1000);

        RuleFor(c => c.TaskItemId)
            .NotEmpty().WithMessage("Comentário deve estar associado a uma tarefa.");

        RuleFor(c => c.UserId)
            .NotEmpty().WithMessage("Comentário deve ter um autor.");
    }
}