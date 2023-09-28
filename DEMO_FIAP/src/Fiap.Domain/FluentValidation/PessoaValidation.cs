using Fiap.Domain.Models;
using Fiap.Domain.Validations;
using FluentValidation;

namespace Fiap.Domain.FluentValidation
{
    public class PessoaValidation : AbstractValidator<Pessoa>
    {
        public PessoaValidation()
        {
            RuleFor(f => f.Nome)
               .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
               .Length(2, 30)
               .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(f => f.Sobrenome)
               .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
               .Length(2, 30)
               .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");


            When(p => p.CPF != string.Empty, () =>
            {
                RuleFor(f => f.CPF.Length).Equal(CpfValidation.TamanhoCpf)
                .WithMessage("O campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}.");
                RuleFor(f => CpfValidation.Validar(f.CPF)).Equal(true)
                    .WithMessage("O documento fornecido é inválido.");
            });
        }
    }
}
