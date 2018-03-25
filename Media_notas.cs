using System;
namespace Media{
	class Programa{
		static void Main(String[] args){
			int som = 0;
			Console.WriteLine("Digite a 1º nota: ");
			som += Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Digite a 2º nota: ");
			som += Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Digite a 3º nota: ");
			som += Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Digite a 4º nota: ");
			som += Convert.ToInt32(Console.ReadLine());
		}
	}
}