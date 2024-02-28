using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_2
{

    class Exch_FirstnLast_Char
    {
        //program to exchange the first and last characters in a given string and return the new string.
        public void Exchange_Char()
        {
            Console.WriteLine("Enter The String :- ");
            string str = Convert.ToString(Console.ReadLine());
            int last = str.Length;
            string newStr = string.Empty;
            newStr += str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1);
            Console.WriteLine(newStr);

        }
    }
}
