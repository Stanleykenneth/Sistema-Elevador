using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Elevador.Model
{
    public interface IManutencao {
        
        bool EstadoManutencao { get; }
        void AlterarEstadoManutencao(bool estado);
        bool VerificarSolicitacoesPendentes(Queue<Solicitacao> filaSolicitacoes);
    }
}