using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace polimorfismo
{
    abstract class forma_geometrica
    {
        int _largura;
        int _altura;

        public int Largura
        {
            get { return _largura; }
            set { _largura = value; }
        }

        public int Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        public void Apresentar(){
            Console.WriteLine("Este método pertence a classe base...");
        }

        public abstract void Desenhar();//será escrito na classe filho

        public virtual void DesenharOutro()
        {
            Console.WriteLine("Método virtual da classe base");
        }
    }

    class rectangulo : forma_geometrica
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhar retângulo com as dimensões: " + Largura + " x " + Altura);
        }

        public override void DesenharOutro()
        {
            Console.WriteLine("Este é um metodo virtual substituído na classe rectangulo");
        }
    }

    class triangulo : forma_geometrica
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhar um triângulo com as dimensões: " + Largura + " x " + Altura);
        }
    }

    class circunrefencia : forma_geometrica
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhar uma circunferência com as dimensões: " + Largura + " x " + Altura);
        }
    }
}
