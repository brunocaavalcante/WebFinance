using Business.Core.Models;
using Business.Usuarios.Models;
using System;
using System.Text;

namespace Business.Financas.Models
{
    public class Operacao : Entity
    {
        public float Valor { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataVencimento { get; set; }
        public int TipoOperacao { get; set; }
        public Guid NaturezaOperacaoId { get; set; }
        public NaturezaOperacao NaturezaOperacao { get; set; }
        public Guid ContaId { get; set; }
        public Conta Conta { get; set; }
    }
}
