using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Caixa
    {
        private double lado;

        public double Volume()
        {
            return Math.Pow(lado, 3);
        }

        public Caixa()
        {
            lado = 10;
        }

        public Caixa(double d)
        {
            lado = d;
        }

        public static double CaixaLado2()
        {
            float l = 2;
            return Math.Pow(Convert.ToSingle(l),3);
        }
    }
}
