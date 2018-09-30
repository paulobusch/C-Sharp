using System;
namespace Calc{
	class Operacao{
		static void Main(String [] args){
			Console.Write("Informe um número float: ");
			float f = float.Parse(Console.ReadLine());
			Calculadora c = new Calculadora();
			float[] num = {f, 5.896f};
			Console.WriteLine(c.Somar(num).ToString());		
		}
	}
	class Calculadora{
		public float Somar(float[] n){
			return n[0] + n[1];
		}

		public float Subtrair(float[] n){
			return n[0] - n[1];
		}	
	}
}