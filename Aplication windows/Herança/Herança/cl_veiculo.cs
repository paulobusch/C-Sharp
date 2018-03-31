using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herança
{
    abstract class cl_veiculo//abstract - somente para classes que devem ser herdadas e não instanciadas
    {
        public string cor { get; set; }
        public string marca { get; set; }

        abstract public void Acelerar(); //abstract - deve ser reescrita na que herda
        public virtual void Parar()// virtual - o metodo pode ser reescrito
        {
            Console.WriteLine("Parou...");
        }
    }
}
