using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Comparativos
    {
        public void Com(int a, int b)
        {
            Console.WriteLine("Son iguales?");
            if(a == b)
            {
                Console.WriteLine("Si");
            }
            else
            {
                Console.WriteLine("Son diferentes?");
                if (a != b)
                {
                    Console.WriteLine("Si");
                }
            }
            
        }
    }
}
