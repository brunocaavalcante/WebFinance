using Business.Financas.Models;
using System;
using System.Threading.Tasks;

namespace Business.Financas.Interfaces
{
    public interface IFinancaService : IDisposable
    {
        #region Operacao
        Task Saque(Operacao operacao);
        Task Deposito(Operacao despesa);
        Task AtualizarOperacao(Guid Id);       
        #endregion
    }
}
