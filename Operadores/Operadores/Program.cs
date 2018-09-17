using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            var OB = new OperadoresBasicos();
            var CMP = new Comparativos();
            Boolean salir = false;
            while(salir == false)
            {
                Console.WriteLine("Introduce el primer valor");
                int a = Convert.ToInt16(Console.ReadLine()); ;
                Console.WriteLine("Introduce el segundo valor");
                int b = Convert.ToInt16(Console.ReadLine()); ;
                OB.Operadores(a, b);
                CMP.Com(a, b);
            }
        }
    }
}
