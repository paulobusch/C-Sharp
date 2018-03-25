using System;
namespace Media{
	class Programa{
		static void Main(String[] args){
			float som = 0, med;
			string situacao = "";
			Console.WriteLine("Digite a 1º nota: ");
			som += Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Digite a 2º nota: ");
			som += Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Digite a 3º nota: ");
			som += Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Digite a 4º nota: ");
			som += Convert.ToInt32(Console.ReadLine());
			med = som/4;
			Console.WriteLine("\nA media final foi......: " + med);
			if(med>=7){
				situacao = "APROVADO";
			}else if(med>=5){
				situacao = "EM RECUPERAÇÃO";
			}else{
				situacao = "REPROVADO";
			}
			Console.WriteLine( "O aluno está: " + situacao);
		}
	}
}