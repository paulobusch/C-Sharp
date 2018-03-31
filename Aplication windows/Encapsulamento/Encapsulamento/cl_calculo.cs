using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encapsulamento
{
    class cl_calculo
    {
        private int p1 = 5;
        private int p2 = 12;
        private int p3 = 23;

        public int CalcPreco(int preco_i, int tipo_p)
        {
            //calculo do preço final
            switch (tipo_p)
            {
                case 1://alimento
                    preco_i += (preco_i * p1 / 100);
                    break;
                case 2://objeto
                    preco_i += (preco_i * p2 / 100);
                    break;
                case 3://higiene
                    preco_i += (preco_i * p3 / 100);
                    break;
            }
            return preco_i;
        }
    }
}
