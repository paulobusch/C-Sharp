using System;
namespace operadores_relacionais{
	class Programa{
		static void Main(String[] args){
			int x, y;
			Console.WriteLine("Digite um número: ");
			x = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Digite outro número: ");
			y = Convert.ToInt32(Console.ReadLine());
			bool b = (x==y);
			Console.WriteLine("\nY = " + y + "\nX = " + x + "\n\nX == Y: " + b);
			b = (x!=y);
			Console.WriteLine("X <> Y: " + b);
			b = (x>y);
			Console.WriteLine("X  > Y: " + b);
			b = (x<y);
			Console.WriteLine("X  < Y: " + b);
		}
	}
}