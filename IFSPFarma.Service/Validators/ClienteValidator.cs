using FluentValidation;
using IFSPFarmacia.Domain.Entities;

namespace IFSPFarma.Service.Validators
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");
            RuleFor(c => c.Senha)
                .NotEmpty().WithMessage("Por favor informe a senha.")
                .NotNull().WithMessage("Por favor informe a senha.");
            RuleFor(c => c.Login)
                .NotEmpty().WithMessage("Por favor informe o login.")
                .NotNull().WithMessage("Por favor informe o login.");
            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Por favor informe o email.")
                .NotNull().WithMessage("Por favor informe o email.");
        }
    }
}
