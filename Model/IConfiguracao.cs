using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Elevador.Model
{
    public interface IConfiguracao
    {
        void AlterarAndares(int quantidade);
        void AlterarEstrategia(string estrategia);
        void MostrarConfiguracao();       
        void MudarEstadoManutencao(bool estado);
        void MudarEstadoOperacao(bool estado, Queue<Solicitacao> filaSolicitacoes);
    }
  
}