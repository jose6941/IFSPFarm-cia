using FluentValidation;
using IFSPFarmacia.Domain.Entities;

namespace IFSPFarma.Service.Validators
{
    public class FornecedorValidator : AbstractValidator<Fornecedor>
    {
        public FornecedorValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");
            RuleFor(c => c.Cnpj)
                .NotEmpty().WithMessage("Por favor informe o cnpj.")
                .NotNull().WithMessage("Por favor informe o cnpj.");
            RuleFor(c => c.Razaosocial)
                .NotEmpty().WithMessage("Por favor informe a razaosocial.")
                .NotNull().WithMessage("Por favor informe a razaosocial.");           
        }
    }
}
