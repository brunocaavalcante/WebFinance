using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Business.Financas.Models;
using Data.Context;
using Business.Financas.Interfaces;

namespace Data.Repository
{
    public class NaturezaOperacaoRepository : Repository<NaturezaOperacao>, INaturezaOperacaoRepository
    {
        public NaturezaOperacaoRepository(MeuDbContext db) : base(db) { }

        public async Task<List<NaturezaOperacao>> ObeterNaturezaOpercao()
        {
            return await Db.NaturezaOperacao.AsNoTracking().ToListAsync();
        }
    }
}