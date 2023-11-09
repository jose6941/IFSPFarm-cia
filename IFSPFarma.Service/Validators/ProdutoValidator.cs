using FluentValidation;
using IFSPFarmacia.Domain.Entities;

namespace IFSPFarma.Service.Validators
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(c => c.Quantidade)
                .NotEmpty().WithMessage("Por favor informe a quantidade.")
                .NotNull().WithMessage("Por favor informe a quantidade.");
            RuleFor(c => c.ValorUnitario)
                .NotEmpty().WithMessage("Por favor informe o valor unitario.")
                .NotNull().WithMessage("Por favor informe o valor unitario.");
            RuleFor(c => c.ValorTotal)
                .NotEmpty().WithMessage("Por favor informe o valor total.")
                .NotNull().WithMessage("Por favor informe o valor total.");      
        }
    }
}
