using System;
namespace Sta
{
	public static class Soma
    {
		public static int Somar(int a, int b)
        {
            return a + b;
        }
    }
	class Sta
    {
		static void Main(String[] args)
        {
            Console.WriteLine(Soma.Somar(10, 5).ToString());
        }
    }
}