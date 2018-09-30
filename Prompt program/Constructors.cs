using System;
namespace Contructor
{
	class Constructor
    {
		static void Main(String[] args)
        {
            Const c = new Const("Pedro");
            c.mostrar();
        }
    }
    class Const
    {
        string nome;
        public Const()
        {
            this.nome = "Rodrigo";
        }

        public Const(string nome = "Paulo") : this()
        {
            this.nome = nome;
        }
        public Const(int nome)
        {
            this.nome = nome.ToString();
        }
        public Const(string nome, string t)
        {
            this.nome = nome + t;
        }

		public Const(string nome, string t, string t1)
        {
            this.nome = nome + t + t1;
        }

		public void mostrar()
        {
            Console.WriteLine("Olá, " + nome);
        }
    }
}