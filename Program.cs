using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Sistema_Elevador.Model;


Elevador elevador = new Elevador();      
Queue<Solicitacao> filaSolicitacoes = new Queue<Solicitacao>();


elevador.MostrarDetalhesMovimentacao();

elevador.IncluirSolicitacao(filaSolicitacoes, 3, 7);

elevador.IncluirSolicitacao(filaSolicitacoes, 7, 2);

// Movendo o elevador com base nas solicitações na fila
elevador.MovimentarElevador(filaSolicitacoes);

// Mudando o estado de manutenção para true
elevador.AlterarEstadoManutencao(true);