using System;
namespace Array__01
{
    class Programa
    {
        static void Main(String[] args)
        {
            int[] vetor;
            vetor = new int[5];

            for (int i = 0; i < vetor.Length; i++) {
                vetor[i] = int.Parse(Console.ReadLine());
            }

            foreach (int c in vetor)
            {
                Console.WriteLine(c);
            }
        }
    }
}