using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Financas.Models;

namespace Business.Financas.Interfaces
{
    public interface INaturezaOperacaoService : IDisposable
    {
        Task<List<NaturezaOperacao>> ObterNaturezaOpercao();
        Task<NaturezaOperacao> ObterPorId(Guid Id);
        Task Adicionar(NaturezaOperacao item);
        Task Atualizar(NaturezaOperacao item);
        Task Remover(Guid Id);
    }
}