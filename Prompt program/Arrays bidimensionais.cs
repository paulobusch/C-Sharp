using System;
namespace ArraysBidimensionais
{
	class ArraysBidimensionais
    {
		static void Main(String[] args)
        {
            int[,] dist = new int[3,2];
            dist[0,0] = 1;
            dist[0,1] = 200;
            dist[1,0] = 2;
            dist[1,1] = 150;
            dist[2,0] = 3;
            dist[2,1] = 300;

			//imprime tabela
			for(int i = 0; i < 3; i++)
            {
				for(int j = 0; j < 2; j++)
                {
                    Console.Write(dist[i,j].ToString() + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}