using System;
namespace Foreach
{
    class Foreach
    {
		static void Main(String[] args)
        {
            string[] veiculos = new string[3]{"carro","barco","avião"};
			foreach(string item in veiculos)
            {
                Console.WriteLine(item);
            }
        }
    }
}