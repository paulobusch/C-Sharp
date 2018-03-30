using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesMetodos
{
    class cl_matematica{
        public int Operacoes(int n1, int n2, string operacao){
            int resultado = -1;
            if(operacao == "adição"){
                resultado = n1 + n2;
            }
            else{
                if (operacao == "subtração"){
                    resultado = n1 - n2;
                }
                else{
                    if (operacao == "multiplicação"){
                        resultado = n1 * n2;
                    }
                    else{
                        if (operacao == "divisão"){
                            resultado = n1 / n2;
                        }
                        else{
                            resultado = -1000;
                        }
                    }
                }
            }
            return resultado;
        }
    }
}
