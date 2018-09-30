using System;
namespace Her{
	public class Veiculo
    {
        public int velMax;
        public int pot;
        public int portas;
        public string cor;
        public string modelo;

    }

	public class Carro : Veiculo
    {
        public int tipo;
		public Carro(int tp)
        {
			//1 - Esportivo
			//2 - caminhonete
			//3 - Normal
            tipo = tp;
            if (tipo == 1)
            {
                velMax = 360;
                pot = 250;
                portas = 2;
                cor = "vermelho";
                modelo = "Esportivo";
            }else if(tipo == 2)
            {
                velMax = 150;
                pot = 160;
                portas = 2;
                cor = "Branco";
                modelo = "Caminhonete";
            }
            else
            {
                velMax = 200;
                pot = 140;
                portas = 4;
                cor = "azul";
                modelo = "normal";
            }
        }
		public void mostraCarro()
        {
            Console.WriteLine("Velocidade: " + velMax);
            Console.WriteLine("Potencia..: " + pot);
            Console.WriteLine("Portas....: " + portas);
            Console.WriteLine("Cor.......: " + cor);
            Console.WriteLine("Modelo....: {0}\n", modelo);
        }

    }

	class Her
    {
		static void Main(String[] args)
        {
            Carro c1 = new Carro(1);
            Carro c2 = new Carro(2);
            Carro c3 = new Carro(3);
            c1.mostraCarro();
            c2.mostraCarro();
            c3.mostraCarro();
        }
    }
}