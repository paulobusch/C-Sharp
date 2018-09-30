using System;
using System.Collections.Generic;
namespace Lista
{
	class Lista
    {
		static void Main(String[] args)
        {
            List<string> mochila = new List<string>();
            mochila.Add("corda");
            mochila.Add("pedra");
            mochila.Add("espelho");
            mochila.Add("graveto");

            mochila.Remove("pedra");

            mochila.Insert(2, "maçã");

            mochila.RemoveAt(3);

            Console.WriteLine(mochila.Contains("corda").ToString());

            int tam = mochila.Count;

			//com for
            for (int i = 0; i < tam; i++)
            {
                Console.WriteLine(mochila[i]);
            }

            Console.WriteLine();
            //com foreach
            foreach (string item in mochila)
            {
                Console.WriteLine(item);
            }
        }
    }
}