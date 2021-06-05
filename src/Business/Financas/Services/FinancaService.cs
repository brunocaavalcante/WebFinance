using Business.Core.Notificacoes;
using Business.Core.Services;
using Business.Financas.Interfaces;
using Business.Financas.Models;
using Business.Financas.Validations;
using System;
using System.Threading.Tasks;

namespace Business.Financas.Services
{
    public class FinancaService : BaseService
    {
        private readonly IFinancaService _financaRepository;

        public FinancaService(IFinancaService financaRepository, 
                              INotificador notificador) : base(notificador)
        {
            _financaRepository = financaRepository;
        }
        

        public Task AtualizarOperacao(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task Deposito(Operacao operacao)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _financaRepository?.Dispose();
        }
      

        public Task Saque(Operacao operacao)
        {
            throw new NotImplementedException();
        }
    }
}
