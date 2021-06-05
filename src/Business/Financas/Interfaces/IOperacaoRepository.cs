using Business.Core.Interfaces;
using Business.Financas.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Financas.Interfaces
{
    public interface IOperacaoRepository : IRepository<Operacao>
    {
        Task<List<Operacao>> ObeterOperacoesPorConta(Guid Id);
    }
}
