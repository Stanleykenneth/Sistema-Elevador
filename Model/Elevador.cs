using System;
using System.Collections.Generic;

namespace Sistema_Elevador.Model
{
   

    public class Elevador : IManutencao, IOperacao
    {
        private bool estadoManutencao = false;
        private const int TempoParadaAndar = 3;
        private const int TempoMudancaAndar = 1;
        private int andarAtual = 0; 

        public bool EstadoManutencao => estadoManutencao;

        public void AlterarEstadoManutencao(bool estado)
        {
            estadoManutencao = estado;
            Console.WriteLine($"Estado de manutenção alterado para {(estadoManutencao ? "On" : "Off")}");
        }

        public bool VerificarSolicitacoesPendentes(Queue<Solicitacao> filaSolicitacoes)
        {
            if (filaSolicitacoes.Count > 0)
            {
                Console.WriteLine("Não é possível ativar a manutenção com solicitações pendentes.");
                return false;
            }

            Console.WriteLine("Sistema em modo de manutenção.");
            return true;
        }

        public void MostrarDetalhesMovimentacao()
        {
            
            int andarAtual = 3;
            int totalAndares = 10;
            string direcao = "subindo";

            Console.WriteLine($"O elevador está no andar {andarAtual} de um total de {totalAndares}. Ele está {direcao}.");
            
        }

        public void IncluirSolicitacao(Queue<Solicitacao> filaSolicitacoes, int andarOrigem, int andarDestino)
        {
            filaSolicitacoes.Enqueue(new Solicitacao(andarOrigem, andarDestino));
            Console.WriteLine($"Solicitação adicionada: Origem - {andarOrigem}, Destino - {andarDestino}");
        }

        // Lógica para movimentação do elevador, utilizando as constantes TempoParadaAndar e TempoMudancaAndar
        public void MovimentarElevador(Queue<Solicitacao> filaSolicitacoes)
        {
            while (filaSolicitacoes.Count > 0)
            {
                var solic = filaSolicitacoes.Dequeue();
                var tempoTotal = Math.Abs(solic.AndarDestino - andarAtual) * TempoMudancaAndar + TempoParadaAndar;
                Console.WriteLine($"Movendo para andar {solic.AndarDestino}. Tempo estimado: {tempoTotal} segundos");
                System.Threading.Thread.Sleep(tempoTotal * 1000);
                andarAtual = solic.AndarDestino;
                Console.WriteLine($"Chegou ao andar {andarAtual}. Desembarcando e atendendo solicitação...");
                System.Threading.Thread.Sleep(TempoParadaAndar * 1000);
                Console.WriteLine("Solicitação atendida!");
            }
        }
       
    }
}
