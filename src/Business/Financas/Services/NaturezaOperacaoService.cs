using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Core.Notificacoes;
using Business.Core.Services;
using Business.Financas.Interfaces;
using Business.Financas.Models;

namespace Business.Financas.Services
{
    public class NaturezaOperacaoService : BaseService, INaturezaOperacaoService
    {
        private readonly INaturezaOperacaoRepository _naturezaOperacaoRepository;

        public NaturezaOperacaoService(INotificador notificador, INaturezaOperacaoRepository repository) : base(notificador)
        {
            _naturezaOperacaoRepository = repository;
        }

        public async Task Adicionar(NaturezaOperacao entity)
        {
            if (string.IsNullOrEmpty(entity.Descricao)) return;

            await _naturezaOperacaoRepository.Adicionar(entity);
        }

        public async Task Atualizar(NaturezaOperacao entity)
        {
            if (string.IsNullOrEmpty(entity.Descricao)) return;

            await _naturezaOperacaoRepository.Atualizar(entity);
        }

        public void Dispose()
        {
            _naturezaOperacaoRepository?.Dispose();
        }

        public async Task<List<NaturezaOperacao>> ObterNaturezaOpercao()
        {
            return await _naturezaOperacaoRepository.ObeterNaturezaOpercao();
        }

        public async Task<NaturezaOperacao> ObterPorId(Guid Id)
        {
            return await _naturezaOperacaoRepository.ObterPorId(Id);
        }


        public Task<List<NaturezaOperacao>> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public async Task Delete(NaturezaOperacao item)
        {
            await _naturezaOperacaoRepository.Remover(item);
        }

    }
}