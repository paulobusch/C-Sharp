using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesMetodos
{
    class cl_matematica{
        int v1, v2;
        public int Operacoes(int v1, int v2, string operacao) {
            this.v1 = v1;
            this.v2 = v2;
            int r = 0;
            if (operacao == "adição") {
                r = Adicao();
            } else if (operacao == "subtração") {
                r = Subtracao();
            } else if (operacao == "multiplicação") {
                r = Multiplicacao();
            } else if(operacao == "divisão"){
                r = Divisao();
            }
            return r;
        }
        private int Adicao(){
            return v1 + v2;
        }

        private int Subtracao(){
            return v1 - v2;
        }

        private int Multiplicacao(){
            return v1 * v2;
        }

        private int Divisao(){
            return v1 / v2;
        }
    }
}
