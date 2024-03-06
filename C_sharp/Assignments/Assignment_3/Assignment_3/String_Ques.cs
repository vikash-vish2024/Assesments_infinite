using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class String_Ques
    {
    }
    //Create a Class Program which would be used to accepts two  Strings -
    //FirstName and LastName and call the static method Display() that displays the first name in one line and the LastName
    //in the second line after converting the same to upper case.
    class String_Upper
    {
        static string f_Name,l_Name;
        public static void get_Name()
        {
            Console.WriteLine("Enter first Name -> ");
            f_Name = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter Last Name -> ");
            l_Name = Console.ReadLine().ToUpper();

        }
        public static void Display()
        {
            Console.WriteLine($"First Name is : {f_Name} \n Last Name is : {l_Name}");
        }
    }

    //Create a Program to count the no. of occurrences of a letter in a given string
    //(for example in a string called “OOPS PROGRAMMING”, O appears 3 times)
    //Hint : Accept a string and also the letter to be counted
    class Char_Count
    {
        static string phrase;
        static char ch;
        static int count;
        public static void get_Data()
        {
            Console.Write("Enter any Phrase -> ");
            phrase = Console.ReadLine().ToLower();
            Console.Write("\nEnter the charactor to count -> ");
            ch = Convert.ToChar(Console.ReadLine().ToLower());
        }
        public static void Count_Char()
        {
            foreach(char c in phrase)
            {
                if (c == ch)
                    count++;
            }
        }
        public static void Display()
        {
            Count_Char(); //for count of the character
            Console.WriteLine($"Given Phrase -> {phrase} ");
            Console.WriteLine($"Character to be counted -> {ch}");
            Console.WriteLine($"The '{ch}' has appered {count} times.");
        }
        
    }

}
