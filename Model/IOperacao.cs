using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Elevador.Model
{
    public interface IOperacao {
        
        void MostrarDetalhesMovimentacao();
        void IncluirSolicitacao(Queue<Solicitacao> filaSolicitacoes, int andarOrigem, int andarDestino);
    }
}