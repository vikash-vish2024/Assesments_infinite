using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Check_Equals();
            program.Positive_Negative();
            int total = 0, prod, difference, division;
            total = program.Arthmetic_Operations(15, 10, out difference, out prod, out division);
            Console.WriteLine($"Sum of 15 and 10 is {total}, Product is {prod}, Difference is {difference} and the Division is {division}");
            program.Multiplication_Table();
            program.Compute_Numbers();
            program.Read_Day();
            Console.ReadKey();

        }
        //C# Sharp program to accept two integers and check whether they are equal or not
        public void  Check_Equals()
        {
            int num1, num2;
            Console.WriteLine("Enter First Number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("Given number are equals");
            }
            else if (num1 != num2)
            {
                Console.WriteLine("Given numbers are not equals");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }
        //C# Sharp program to check whether a given number is positive or negative
        public void Positive_Negative()
        {
            Console.WriteLine("Enter the number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 < 0)
            {
                Console.WriteLine(num1+" is negative number");
            }
            else if (num1 >= 0)
            {
                Console.WriteLine(num1+" is positive number");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

        }
        //C# Sharp program that takes two numbers as input and performs all operations (+,-,*,/) on them and displays the result of that operation
        public int Arthmetic_Operations(int num1, int num2, out int prod,out int div,out int diff )
        {
            diff = num1 - num2;
            prod = num1 * num2;
            div = num1 / num2;
            return num1 + num2;

        }
        //C# Sharp program that prints the multiplication table of a number as input
        public void Multiplication_Table()
        {
            Console.WriteLine("Enter the Number");

            int num1 = Convert.ToInt32(Console.ReadLine());
            for(int i =1; i <= num1; i++)
            {
                Console.WriteLine(num1+" * "+i+" = "+num1*i);
            }
        }
        public void Compute_Numbers()
        {
            Console.WriteLine("Enter the first number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Sum of {0} and {1} is :",num1,num2);
            if (num1 == num2)
            {
                Console.WriteLine("Triple of there Sum is : "+(num2+num1)*3);
            }
            else
            {
                Console.WriteLine(" Given number is different");
            }
        }
        //C# Sharp program to read any day number as an integer and display the name of the day as a word
        public void Read_Day()
        {
            Console.WriteLine("Enter the number between 1-7: ");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }

    }
}
