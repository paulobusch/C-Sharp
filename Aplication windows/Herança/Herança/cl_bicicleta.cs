using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herança
{
    class cl_bicicleta : cl_veiculo
    {
        public void Pedalar()
        {

        }

        public override void Acelerar()// override - função reescrita de classe pai
        {
            Console.WriteLine("A bicicleta Acelerou...");
        }
    }
}
