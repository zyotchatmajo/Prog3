using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un nombre de usuario que no tenga caracteres especiales");
            String user = Console.ReadLine();
            try
            {
                new DB(user);
            }
            catch (UserException ex)
            {
                Console.WriteLine("Introduce otro usuario");
            }
            
        }
    }
}
