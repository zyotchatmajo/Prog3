using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerP
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean Banderin = false;
            byte byteType = 10;
            char caracter = 'A';
            int Entero = 256;
            String Cadena = "TEST";
            long longT = 68686866;
            float flotante = 3.14f;
            double doublet = 3.1431;
            Console.WriteLine("Data Type Bool : " + Banderin);
            Console.WriteLine("Data Type Byte : " + byteType);
            Console.WriteLine("Data Type Char : " + caracter);
            Console.WriteLine("Data Type Int : " + Entero);
            Console.WriteLine("Data Type String : " + Cadena);
            Console.WriteLine("Data Type Long : " + longT);
            Console.WriteLine("Data Type Float : " + flotante);
            Console.WriteLine("Data Type Double : " + doublet);
            Entero = (int) byteType;
            Console.WriteLine("Byte Data Type To Integer Data Type : " + Entero);
            longT = (long) Entero;
            Console.WriteLine("Int Data Type to Long Data Type : " + longT);
        }
    }
}
