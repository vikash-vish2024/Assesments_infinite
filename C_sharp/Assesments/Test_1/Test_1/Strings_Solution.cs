using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Strings_Solution
    {
        public static void Main(String[] Args)
        {
            Strings_Solution strings_solution = new Strings_Solution();
            strings_solution.Func_of_String();
            strings_solution.String_Equals();
            Console.Read();

        }
        public void Func_of_String()
        {
            Console.WriteLine("Enter any String/Your Name : ");
            string s = Convert.ToString(Console.ReadLine());
            //Length of the String
            Console.WriteLine("The length of the given String is -> " + s.Length);
            //Reverse of the given string
            char[] rev = s.Reverse().ToArray();
            Console.WriteLine("________________________");
            for (int i = 0; i < rev.Length; i++)
            {
                Console.Write(rev[i]);
               
            }

        }
        public void String_Equals()
        {
            Console.WriteLine("Enter the first String");
            string first = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the second String");
            string second = Convert.ToString(Console.ReadLine());
            if (first.Equals(second))
            {
                Console.WriteLine("Given string are Same");
            }
            else
            {
                Console.WriteLine("Given Strings are different");
            }
        }
    }
}
