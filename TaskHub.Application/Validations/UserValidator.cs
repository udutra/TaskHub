using FluentValidation;
using TaskHub.Domain.Entities;

namespace TaskHub.Application.Validations;


public class UserValidator : AbstractValidator<User>{
    public UserValidator(){
        RuleFor(u => u.UserName)
            .NotEmpty().WithMessage("Nome de usuário é obrigatório.")
            .MaximumLength(80);

        RuleFor(u => u.Email)
            .NotEmpty().EmailAddress().WithMessage("Email inválido.").MaximumLength(100);;

        RuleFor(u => u.FullName)
            .NotEmpty().WithMessage("Nome completo é obrigatório.")
            .MaximumLength(150);
    }
}