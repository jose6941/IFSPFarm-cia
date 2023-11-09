using FluentValidation;
using IFSPFarmacia.Domain.Entities;

namespace IFSPFarma.Service.Validators
{
    public class VendaValidator : AbstractValidator<Venda>
    {
        public VendaValidator()
        {
            RuleFor(c => c.Data)
                .NotEmpty().WithMessage("Por favor informe a data.")
                .NotNull().WithMessage("Por favor informe a data.");                   
        }
    }
}
