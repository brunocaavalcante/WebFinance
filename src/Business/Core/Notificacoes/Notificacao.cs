using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Core.Notificacoes
{
    public class Notificacao
    {
        public string Mensagem { get; }
        public Notificacao(string msg)
        {
            Mensagem = msg;
        }
    }
}
