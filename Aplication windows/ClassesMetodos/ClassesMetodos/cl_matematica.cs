using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesMetodos
{
    class cl_matematica{
        public int Operacoes(int n1, int n2, string operacao){
            int resultado = -1;
            switch (operacao)
            {
                case "adicao":
                    resultado = n1 + n2;
                    break;
                case "subtracao":
                    resultado = n1 - n2;
                    break;
                case "multiplicacao":
                    resultado = n1 * n2;
                    break;
                case "divisao":
                    resultado = n1 / n2;
                    break;
            }
            return resultado;
        }
    }
}
