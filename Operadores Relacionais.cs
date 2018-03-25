using System;
namespace operadores_relacionais{
	class Programa{
		static void Main(String[] args){
			int x, y = 0;
			Console.WriteLine("Digite um número: ");
			x = Convert.ToInt32(Console.ReadLine());
			bool b = (x==y);
			Console.WriteLine("\nY = 0\n\nX == Y: " + b);
			b = (x!=y);
			Console.WriteLine("\nX <> Y: " + b);
		}
	}
}