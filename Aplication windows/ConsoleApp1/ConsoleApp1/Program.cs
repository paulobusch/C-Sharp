using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Caixa c = new Caixa(10);
            Console.WriteLine(c.Volume().ToString());
            Console.ReadKey();
        }
    }
}
