using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesParametros
{
    class teste
    {
        public void Acrescentar(ref int valor){
            valor += 5;
        }

        public void Diminuir(ref int valor){
            valor -= 5;
        }
    }
}
