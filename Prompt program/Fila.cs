using System;
using System.Collections.Generic;
namespace Fila
{
    class Fila
    {
        static void Main(String[] args)
        {
            Queue<string> Fila = new Queue<string>();

            Fila.Enqueue("1");//adiciona a fila
            Fila.Enqueue("2");
            Fila.Enqueue("3");

            Console.WriteLine(Fila.Peek());//retorna primeiro elemento
            Console.WriteLine(Fila.Dequeue());//retorna e remove

            Console.WriteLine();
            foreach (string item in Fila)
            {
                Console.WriteLine(item);
            }
        }
    }
}