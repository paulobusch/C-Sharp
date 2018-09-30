using System;
namespace abst
{
	public abstract class Robo
    {
        public int forca;
        public int velMax;
        public int bateria;
    }

	class Inimigos : Robo
    {
        static public int estado;
        public string nome;
        public bool vivo;

		public Inimigos(int es, string n, int f, int velM, int en)
        {
            estado = es;
            nome = n;
            forca = f;
            velMax = velM;
            bateria = en;

            if (bateria > 0)
            {
                vivo = true;
            }
            else
            {
                vivo = false;
            }
        }

		public void mudaEstado(int es)
        {
            estado = es;
        }

		public void mostraEstado()
        {
            Console.WriteLine("Estado do robo " + nome + " é " + estado);
        }
    }

	public class Abs
    {
		static void Main(String[] args)
        {
            Inimigos ini1 = new Inimigos(1,"Eletron",200,50,100);
            Inimigos ini2 = new Inimigos(3,"Raio",150,70,100);
            Inimigos ini3 = new Inimigos(2,"Tectron",100,100,100);

            ini1.mudaEstado(1);

            ini1.mostraEstado();
            ini2.mostraEstado();
            ini3.mostraEstado();
        }
    }
}