using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_3
{
    class Calling_Main
    {

        static void Main(string[] args)
        {
            //Text_Writer 
            Console.WriteLine("----Writing text on file using File_Writer----");
            //Console.Write("Enter the text to write in file -> ");
            //string txt = Convert.ToString(Console.ReadLine());

            //Text_Writer.File_Writer(txt);

            Console.WriteLine("---------------------------------------------------------------------------\n\n");

            //Calling Calculator_Fun
            Console.WriteLine("----Calculator Function using Delegates----");

            //Taking input from user
            Console.Write("Enter first integers-> ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second integers-> ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            //initializing delegates
            Arithmetic_Exp sum = Calculator_fun.Addition;
            Arithmetic_Exp diff = Calculator_fun.Subtract;
            Arithmetic_Exp prod = Calculator_fun.Multiply;
            Arithmetic_Exp div = Calculator_fun.Division;

            //Displaying the Result
            Console.WriteLine($"Sum-> {sum(n1,n2)}, Difference-> {diff(n1,n2)}, Product-> {prod(n1,n2)} and Division-> {(float)div(n1,n2)}");

            Console.WriteLine( "---------------------------------------------------------------------------\n\n");

            //Employee Record Calling
            Console.WriteLine("----Storing Employee Details using Generic and Display it accordingly---");
            Employees.Emp_Records();
            
        }
    }
}
