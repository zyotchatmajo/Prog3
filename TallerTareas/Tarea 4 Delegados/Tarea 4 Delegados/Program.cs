using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int funciones(int n);

namespace Tarea_4_Delegados
{
    class Program
    {
        static int num = 0;
        static int mayora = 0;
        public static int suma(int p)
        {
            num += p;
            return num;
        }
        public static int promedio(int p)
        {
            return num / 5;

        }
        public static int mayor(int p)
        {
            if(p > mayora)
            {
                mayora = p;
                
            }
            return mayora;
        }
        static void Main(string[] args)
        {
            int[] Array = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Introduce el valor " + (i + 1));
                Array[i] = Convert.ToInt16(Console.ReadLine());
            }
            funciones sumaf = new funciones(suma);
            funciones prom = new funciones(promedio);
            int sumat = 0;
            int numtmp = 0;
            for (int i = 0; i < 5; i++)
            {
                sumat = sumaf(Array[i]);
            }
            Console.WriteLine("La suma de los valores es : "+sumat);
            Console.WriteLine("El promedio de los valores es : " + prom(1));
            for (int i = 0; i < 5; i++)
            {
                numtmp = mayor(Array[i]);   
            }
            Console.WriteLine("El mayor es : " + numtmp);
        }
    }
}
