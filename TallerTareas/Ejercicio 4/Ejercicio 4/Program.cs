using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arreglo = new int[,] {
                { 1,9,23,34,102},
                { 2,8,67,56,23},
                { 3,7,84,78,43},
                { 4,5,90,98,34}
            };
            bool xd = false;
            for (int i = 0; i < 5; i++)
            {
                if(xd == true)
                {
                    for (int j = 3; j >= 0; j--)
                    {
                        Console.Write(arreglo[j,i] + " , ");
                    }
                    xd = false;
                }
                else
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(arreglo[j, i]+" , ");
                    }
                    xd = true;
                }
                
            }

        }
    }
}
