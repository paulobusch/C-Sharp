using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herança
{
    class cl_carro : cl_veiculo
    {
        public int vel_m { get; set; }

        public void LigarMotor()
        {

        }

        public override void Acelerar() // override - função reescrita de classe pai
        {
            Console.WriteLine("O carro acelerou...");
        }

        public override void Parar()//overrinde - para reescrita da classe
        {
            Console.WriteLine("O carro está parando...");
        }
    }
}
