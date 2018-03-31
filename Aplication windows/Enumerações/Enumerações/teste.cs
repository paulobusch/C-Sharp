using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enumerações
{
    class teste
    {
        public enum DiasDaSemana
        {
            domingo, segunda, terça, quarta, quinta, sexta, sábado
        }

        public enum Movimento { direita, esquerda, cima, baixo}
        public void ApresentarDia(DiasDaSemana dia)
        {
            Console.WriteLine("O dia escolhido foi " + dia);
        }

        public void Mover(Movimento direcao)
        {
            Console.WriteLine("O jogador moveu-se para " + direcao);
        }
    }
}
