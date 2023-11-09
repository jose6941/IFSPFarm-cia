using FluentValidation;
using IFSPFarmacia.Domain.Entities;

namespace IFSPFarma.Service.Validators
{
    public class FarmaceuticoValidator : AbstractValidator<Farmaceutico>
    {
        public FarmaceuticoValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");
            RuleFor(c => c.Endereco)
                .NotEmpty().WithMessage("Por favor informe o endereço.")
                .NotNull().WithMessage("Por favor informe o endereço.");
            RuleFor(c => c.Idade)
                .NotEmpty().WithMessage("Por favor informe a idade.")
                .NotNull().WithMessage("Por favor informe a idade.");
            
        }
    }
}
