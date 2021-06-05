using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Core.Interfaces;
using Business.Financas.Models;

namespace Business.Financas.Interfaces
{
    public interface INaturezaOperacaoRepository: IRepository<NaturezaOperacao>
    {
       Task<List<NaturezaOperacao>> ObeterNaturezaOpercao();  
    }
}