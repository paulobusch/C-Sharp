using System;
namespace IF{
	class Programa{
		static void Main(String[] args){
			int n = 0;
			string t = "\nO número digitado é ";
			Console.WriteLine("Digite um número: ");
			n = Convert.ToInt32(Console.ReadLine());
			if(n > 0){
				Console.WriteLine(t + "positivo\n\n");
			}else{
				Console.WriteLine(t + "negativo\n\n");
			}
		}
	}
}