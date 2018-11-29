using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception
{
    class UserException : Exception
    {
        public UserException()
        {
            Console.WriteLine("Se encontraron caracteres especiales");
        }
    }
}
