using System;
namespace IF{
	class Programa{
		static void Main(String[] args){
			int n = 0;
			Console.WriteLine("Digite um número: ");
			n = Convert.ToInt32(Console.ReadLine());
			if(n > 0){
				Console.WriteLine("\n\nO número digitado é positivo\n\n");
			}else{
				Console.WriteLine("\n\nO número digitado é negativo\n\n");
			}
		}
	}
}