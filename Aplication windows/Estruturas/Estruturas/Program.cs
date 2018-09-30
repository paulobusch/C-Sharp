using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estruturas
{
    class Program
    {

        struct Horario
        {
            private int hora, minuto, segundo;

            public Horario(int h, int m, int s)
            {
                this.hora = h;
                this.minuto = m;
                this.segundo = s;
            }

            public int Hora()
            {
                return this.hora;
            }
        }

        static void Main(string[] args)
        {
            Horario agora = new Horario(20,10,15);
            Console.WriteLine("Agora são {0} horas",agora.Hora());
            Console.ReadKey();
        }
    }
}
