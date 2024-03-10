using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    
    class Lambda_Queries
    {
        //Write a query that returns list of numbers and their suares only if the square is greater than 20
        static List<int> Number = new List<int>();
        public static void Get_List_Numbers()
        {
            Console.Write("Enter the size of the list -> ");
            int size = int.Parse(Console.ReadLine());
            for(int i=0; i < size; i++)
            {
                int value;
                Console.Write($"Enter The {i+1} Value -> ");
                value = int.Parse(Console.ReadLine());
                Number.Add(value);
            }
        }
        public static void Square()
        {
            var square = Number.Select(nm => nm * nm);

            Console.WriteLine("Square of the numbers :");
            foreach (var val in square)
            {
                if (val > 20) Console.Write(val + " "); ;
            }
            Console.WriteLine();
        }

        // Write a query that returns words starting with letter 'a' and ending with letter 'm'

        static List<string> Words = new List<string>();
        public static void Get_List_Words()
        {
            Console.Write("Enter the size of the list -> ");
            int size = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                string word;
                Console.Write($"Enter The {i + 1} Word -> ");
                word = Console.ReadLine().ToLower();
                Words.Add(word);
            }
        }
        public static void Print_Words()
        {
            var word = Words.Where(w => w.StartsWith("a") && w.EndsWith("m"));
            foreach(var wd in word)
            {
                Console.Write(wd + " ");
            }
        }
    }
}
