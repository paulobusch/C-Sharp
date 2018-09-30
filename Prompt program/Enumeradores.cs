using System;
using System.Collections.Generic;
namespace Enumeradores
{
    class Enumeradores
    {
		enum mochila{caderno, livro, penal, regua};

        static void Main(String[] args)
        {
			int itemSel;

            itemSel = (int) mochila.caderno;//tipecast
            Console.WriteLine(itemSel.ToString());
        }
    }
}