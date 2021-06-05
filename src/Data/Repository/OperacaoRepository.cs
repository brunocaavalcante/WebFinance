using Business.Financas.Interfaces;
using Business.Financas.Models;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class OperacaoRepository : Repository<Operacao>, IOperacaoRepository
    {
        public OperacaoRepository(MeuDbContext db) : base(db) {}
        public async Task<List<Operacao>> ObeterOperacoesPorConta(Guid Id)
        {
            return await Db.Operacoes.AsNoTracking().Include(n => n.NaturezaOperacao)
               .Where(o => o.Conta.Id == Id).ToListAsync();
        }
    }
}
