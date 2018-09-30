using System;
using System.Drawing;
namespace Methods
{
	public class Ponto
    {
        public int X;
        public int Y;

		public Ponto(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

		public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

		public void Move(Point newLocation)
        {
            this.X = newLocation.X;
            this.Y = newLocation.Y;
        }
    }

	class Program
    {
		static void Main(String[] args)
        {
            var P = new Ponto(10, 20);
            P.Move(new Point(40, 60));
            Console.WriteLine("O ponto é {0}, {1}", P.X, P.Y);
        }
    }
}