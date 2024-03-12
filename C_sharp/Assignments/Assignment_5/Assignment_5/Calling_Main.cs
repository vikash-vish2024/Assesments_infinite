using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Calling_Main
    {
        static void Main(string[] args)
        {
            //BookSelf 

            Console.WriteLine("-----BooksSelf Setting and Displaying-----");
            Test_Books test_books = new Test_Books();
            //test_books.Books_Self();
           

            Console.WriteLine("-------------------------------------------------------------------\n\n");

            //Box  
            Console.WriteLine("-----Box Class Execution-----");
            //Test_Box.Testing_Box();

            Console.WriteLine("-------------------------------------------------------------------\n\n");

            //Employee 
            Test_Emp.Setting_Emp();
            Test_Emp.Display_Emp();

            Console.WriteLine("-------------------------------------------------------------------\n\n");

            //student
            Student student = new Student();
            Console.WriteLine("-----Student class Execution-----");
            student.Test_Student();
        }
    }
}
