using System;
namespace Calculadora{
	class Programa{
		static void Main(String[] args){
			float n1, n2, operacao;
			string tmp; //valor temporário de leitura
			Console.WriteLine("Digite um número: ");
			tmp = Console.ReadLine();//realiza leitura
			n1 = int.Parse(tmp);//converte para float
			Console.Write("Digite outro número: ");
			tmp = Console.ReadLine();
			n2 = int.Parse(tmp);
			operacao = n1 + n2;//soma
			Console.WriteLine("\nA soma vale: " + operacao);
			operacao = n1 - n2;//subtração
			Console.WriteLine("A diferença é: " + operacao);
			operacao = n1 * n2;//multiplicação
			Console.WriteLine("O produto é: " + operacao);
			operacao = n1 / n2;//divisão
			Console.WriteLine("A divisão é: " + operacao + "\n");
		}
	}
}