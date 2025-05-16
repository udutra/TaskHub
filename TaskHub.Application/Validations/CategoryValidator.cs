using FluentValidation;
using TaskHub.Domain.Entities;

namespace TaskHub.Application.Validations;

public class CategoryValidator : AbstractValidator<Category>{
    public CategoryValidator(){
        RuleFor(c => c.Name)
            .NotEmpty().WithMessage("Nome da categoria é obrigatório.")
            .MaximumLength(50);
        RuleFor(x => x.Description)
            .MaximumLength(500);
    }
}