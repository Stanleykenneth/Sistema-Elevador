using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Elevador.Model
{
     public class Solicitacao
    {
        public int AndarOrigem { get; }
        public int AndarDestino { get; }

        public Solicitacao(int origem, int destino)
        {
            AndarOrigem = origem;
            AndarDestino = destino;
        }
    }
}