using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Custom_Exception
{
    class DB
    {
        public DB(String user)
        {
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");

            if (!regexItem.IsMatch(user)) {
                throw new UserException();
            }
            else
            {
                Console.WriteLine("OK");
            }
        }
    }
}
