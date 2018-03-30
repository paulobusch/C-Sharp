using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesParametros
{
    class teste
    {
        public int Acrescentar(int valor = 20, int x){
            valor += x;
            return valor;
        }

        public void Diminuir(ref int valor){
            valor -= 5;
        }
    }
}
