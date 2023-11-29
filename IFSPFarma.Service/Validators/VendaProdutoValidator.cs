using FluentValidation;
using IFSPFarmacia.Domain.Entities;

namespace IFSPFarma.Service.Validators
{
    public class PedidoValidator : AbstractValidator<VendaProduto>
    {
        public PedidoValidator()
        {
            RuleFor(c => c.Total)
                .NotEmpty().WithMessage("Por favor informe o total.")
                .NotNull().WithMessage("Por favor informe o total.");
            RuleFor(c => c.Desconto)
                .NotEmpty().WithMessage("Por favor informe o desconto.")
                .NotNull().WithMessage("Por favor informe o desconto.");
            RuleFor(c => c.Quantidade)
                .NotEmpty().WithMessage("Por favor informe a quantidade.")
                .NotNull().WithMessage("Por favor informe a quantidade.");         
        }
    }
}
