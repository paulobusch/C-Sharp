using System;
namespace Media{
	class Programa{
		static void Main(String[] args){
			float som = 0, med;
			string frase = "Digite a {0}º nota: ", situacao = "";
			Console.WriteLine(frase, 1);
			som += Convert.ToSingle(Console.ReadLine());
			Console.WriteLine(frase, 2);
			som += Convert.ToSingle(Console.ReadLine());
			Console.WriteLine(frase, 3);
			som += Convert.ToSingle(Console.ReadLine());
			Console.WriteLine(frase, 4);
			som += Convert.ToSingle(Console.ReadLine());
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