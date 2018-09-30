using System;
namespace Prop
{
    public class carro
    {

        private int velMax;
        public int torque;
        public int potencia;
        public string cor;

        public carro(int vM, int t, int p, string c)
        {
            velMax = vM;
            torque = t;
            potencia = p;
            cor = c;
        }

		public void mostraVel()
        {
            Console.WriteLine("Velocidade máxima " + velMax);
        }

		public void mostraCor()
        {
            Console.WriteLine("Cor " + cor);
        }

		public int retVelM()
        {
            return velMax;
        }

		public string retCor()
        {
            return cor;
        }
    }

    class Prop
    {
        static void Main(String[] args)
        {
            carro c1 = new carro(300, 45, 220, "vermelho");
            carro c2 = new carro(200, 25, 140, "preto");
            Console.WriteLine("Velocidade " + c1.retVelM());
            Console.WriteLine("Cor " + c1.retCor());
            Console.WriteLine("Velocidade " + c2.retVelM());
            Console.WriteLine("Cor " + c2.retCor());
			/*
            c1.mostraVel();
            c1.mostraCor();
            c2.mostraVel();
            c2.mostraCor();
			*/
        }
    }
}