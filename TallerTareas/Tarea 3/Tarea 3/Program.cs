using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3
{
    class Program
    {
        public struct Numeros
        {
            public int x, y;

            public Numeros(int p1, int p2)
            {
                x = p1;
                y = p2;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Suma de 2 numeros usando Struct");
            Numeros suma = new Numeros(10, 20);
            Console.WriteLine("Numero 1: " + suma.x);
            Console.WriteLine("Numero 2: " + suma.y);
            Console.WriteLine("La suma de los 2 numeros es : "+(suma.x + suma.y));
        }
    }
}
