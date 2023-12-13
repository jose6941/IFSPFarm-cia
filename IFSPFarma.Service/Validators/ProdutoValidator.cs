using FluentValidation;
using IFSPFarmacia.Domain.Entities;

namespace IFSPFarma.Service.Validators
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {           
            RuleFor(c => c.Descricao)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");
        }
    }
}
