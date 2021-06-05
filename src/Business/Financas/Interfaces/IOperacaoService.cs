using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Core.Interfaces;
using Business.Financas.Models;

namespace Business.Financas.Interfaces
{
    public interface IOperacaoService  : IRepository<Operacao>
    {
        Task Salvar(Operacao item);   
        Task Editar(Operacao item);
        Task Remover(Guid Id);
        Task<List<Operacao>> Listar();      
    }
}