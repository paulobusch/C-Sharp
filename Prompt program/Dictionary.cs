using System;
using System.Collections.Generic;
namespace Dictionary
{
	class Dictionary
    {
		static void Main(String[] args)
        {
            Dictionary<string, int> dicionario; 
			dicionario = new Dictionary<string, int>();

            dicionario.Add("mouse", 10);
            dicionario.Add("telefone", 3);
            dicionario.Add("impressora", 9);
            dicionario.Add("monitor", 3);

            foreach (KeyValuePair<string,int> item in dicionario)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }

            //dicionario.ContainsKey("mouse");
            //dicionario.ContainsValue(10);

            //dicionario["mouse"]
            //dicionario.Remove("mouse");

			/*
            foreach (int item in dicionario.Values)
            {
                Console.WriteLine(item.ToString());
            }
			*/
        }
    }
}