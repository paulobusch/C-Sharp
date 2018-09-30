using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace @virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mamifero m = new Mamifero();
            Humano h = new Humano();
            Gato g = new Gato();

            h.Mamar();
            h.Lutar();
            h.Falar();
            //h.teste = "ggdfg";
            Console.ReadKey();
        }
    }
    abstract class Mamifero
    {
        public abstract int Area();//deve ser reescrita na classe filho
        protected string teste = " teste";
        public void Respirar()
        {
            Console.WriteLine("respira!");
        }
        public void Mamar()
        {
            Console.WriteLine("mama!");
        }
        public virtual void Lutar()
        {
            Console.WriteLine("Mamiferos lutam entre si!");
        }
        
    }
    sealed class Humano : Mamifero
    {
        public override int Area() // escrita do metodo abstrato
        {
            return 0;
        }
        public void Falar()
        {
            Console.WriteLine("falar!" + teste);
        }
        public override void Lutar()
        {
            Console.WriteLine("Humanos lutam com armas!");
        }
    }
    sealed class Gato : Mamifero
    {
        public override int Area() // reescrita do metodo abstrato
        {
            return 0;
        }
        public void Arranhar()
        {
            Console.WriteLine("Arranha");
        }
    }
}
