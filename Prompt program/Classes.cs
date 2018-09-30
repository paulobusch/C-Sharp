using System;
namespace Classes
{
	public class carro
    {

        public int velMax;
        public int torque;
        public int potencia;
        public string cor;

        public carro(int vM, int t, int p, string c) {
            velMax = vM;
            torque = t;
            potencia = p;
            cor = c;
        }
    }

	class Classes
    {
		static void Main(String[] args)
        {
            carro c1 = new carro(300, 45, 220, "vermelho");
            carro c2 = new carro(200, 25, 140, "preto");

            Console.WriteLine("Velocidade máxima " + c1.velMax);
            Console.WriteLine("Velocidade máxima " + c2.velMax);
        }
    }
}