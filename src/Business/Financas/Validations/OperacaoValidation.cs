using Business.Financas.Models;
using FluentValidation;
using System;

namespace Business.Financas.Validations
{
    public class OperacaoValidation : AbstractValidator<Operacao>
    {
        public OperacaoValidation()
        {
            RuleFor(d => d.Descricao)
                .NotEmpty().WithMessage("O campo {PropertyName} deve ser fornecido.")
                .Length(4, 1000).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres.");

            RuleFor(d => d.DataVencimento)
                .NotEmpty().WithMessage("O campo {PropertyName} deve ser fornecido.")
                .NotNull().WithMessage("O campo {PropertyName} deve ser fornecido.")
                .When(d => d.DataVencimento < DateTime.Now).WithMessage("A data de vencimento não pode ser menor que a data atual.");
            
            RuleFor(o => o.Valor < 0).Equal(true).WithMessage("O campo {PropertyName} não pode ser negativo.")
                .NotNull().NotEmpty().WithMessage("O campo {PropertyName} deve ser preenchido.");
        }                   
    }
}
