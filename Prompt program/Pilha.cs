using System;
using System.Collections.Generic;
namespace Pilha
{
    class Pilha
    {
        static void Main(String[] args)
        {
            Stack<string> Pilha = new Stack<string>();

            Pilha.Push("Orc");//adiciona
            Pilha.Push("mago");
            Pilha.Push("elfo");
            Pilha.Push("anão");
            Pilha.Push("ultimo");

            Console.WriteLine(Pilha.Pop());//mostra e retira da pilha
            //Pilha.Peek();//-retorna carta do topo
            int tam = Pilha.Count;
            foreach (string item in Pilha) {
                Console.WriteLine(item);
            }
			
        }
    }
}