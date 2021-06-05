using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Core.Models
{
    public abstract class Pessoa : Entity
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
    }
}
