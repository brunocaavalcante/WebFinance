using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Core.Interfaces;
using Business.Core.Notificacoes;
using Business.Core.Services;
using Business.Financas.Interfaces;
using Business.Financas.Models;
using Business.Financas.Validations;

namespace Business.Financas.Services
{
    public class OperacaoService : BaseService, IOperacaoService
    {
        private readonly IOperacaoRepository _operacaoRetository;
        public OperacaoService(IOperacaoRepository repository,
                                INotificador notificador) : base(notificador)
        {
            _operacaoRetository = repository;
        }
        public async Task Adicionar(Operacao entity)
        {
            if(!ExecutarValidacao(new OperacaoValidation(), entity)) return;
            
            await _operacaoRetository.Adicionar(entity);
        }

        public Task Atualizar(Operacao entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task Editar(Operacao item)
        {
            throw new NotImplementedException();
        }

        public Task<List<Operacao>> Listar()
        {
            throw new NotImplementedException();
        }

        public Task<Operacao> ObterPorId(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Operacao>> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public Task Remover(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task Salvar(Operacao item)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChanges()
        {
            throw new NotImplementedException();
        }

        Task<int> IRepository<Operacao>.Remover(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}