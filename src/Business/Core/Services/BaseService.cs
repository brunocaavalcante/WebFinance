using Business.Core.Models;
using Business.Core.Notificacoes;
using FluentValidation;
using FluentValidation.Results;

namespace Business.Core.Services
{
    public abstract class BaseService
    {
        private readonly INotificador _notificador;
        public BaseService(INotificador notificador)
        {
            _notificador = notificador;
        }
        protected bool ExecutarValidacao<TV,TE>(TV validacao, TE entidade) where TV : AbstractValidator<TE> where TE : Entity
        {
            var validador = validacao.Validate(entidade);
            
            if (validador.IsValid) return true;

            Notificar(validador);
            return false;
        }
        protected void Notificar(ValidationResult validator)
        {
            foreach (var erro in validator.Errors)
            {
                Notificar(erro.ErrorMessage);
            }
        }
        protected void Notificar(string mensagem)
        {
            _notificador.AdicionarNotificacao(new Notificacao(mensagem));
        }
    }
}
