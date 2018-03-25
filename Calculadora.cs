using System;
namespace Calculadora{
	class Programa{
		static void Main(String[] args){
			float n1, n2, soma;
			string tmp; //valor temporário de leitura
			Console.WriteLine("Digite um numero numero: ");
			tmp = Console.ReadLine();//realiza leitura
			n1 = int.Parse(tmp);//converte para float
			Console.Write("Digite outro número: ");
			tmp = Console.ReadLine();
			n2 = int.Parse(tmp);
			soma = n1 + n2;
			Console.WriteLine("A soma vale: " + soma);//efetua soma
		}
	}
}