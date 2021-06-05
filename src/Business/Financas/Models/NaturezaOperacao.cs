using Business.Core.Models;
using System.Collections.Generic;

namespace Business.Financas.Models
{
    public class NaturezaOperacao:Entity
    {
        public List<Operacao> Operacao { get; set; }
        public string Descricao { get; set; }
    }
}
