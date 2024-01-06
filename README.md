# Sistema Elevador

Este pequeno projeto teve como objetivo de estruturar meus conhecimentos com Orientação a Objeto,
onde tentei usar os quatro pilares do POO, Abstração, Encapsulamento, Herança e Polimormfismo; 
claro que não poderia deixar de pensar na organização de um código facil de ler e facil de dar
manutenção.

Ao me deparar com o texto do exercício proprosto, elaborei um UML com a finalidade da ficar mais claro
na hora de implementar esse exercício.


O tema Proposto foi criar um sistema de um elevador.

Tema: sistema para elevador
Para começar, teremos 3 interfaces de interação
CONFIGURAÇÃO -> onde poderemos inserir ou alterar a quantidade de andares e estratégia de
operação (que será detalhada posteriormente).
MANUTENÇÃO -> estado on/off. As configurações só podem ser mexidas se estiver on. Só pode
ser colocado em modo on se a fila de solicitações estiver vazia.
OPERAÇÃO -> mostra os detalhes da movimentação do elevador e aceita a inclusão de novas
solicitações a qualquer momento. Cada solicitação deve contér andar origem + andar destino.
Constantes:
- Consideraremos que cada parada em algum andar tomará 3 segundos. Significa que em caso de ser
a última viagem da fila, esses 3 segundos representarão o desembargue e só depois será considerado
que tudo foi atendido.
- Consideraremos que o elevador leva 1 segundo para mudar de andar.
- Quando o programa rodar, o elevador "nasce" no andar térreo.
Estratégias:
São as formas que o motor deve compreender e operar, de acordo com a operação escolhida na
interface de configuração

