using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Core.Notificacoes
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void AdicionarNotificacao(Notificacao notificacao);
    }
}
