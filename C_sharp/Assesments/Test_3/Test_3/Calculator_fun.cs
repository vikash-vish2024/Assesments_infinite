using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_3
{
    //Write a console program that uses delegates to call Calculator Functionalities like 1. Addition, 2. Subtraction and
    //3. Multiplication by taking 2 integers and returns the answer to the user.
    //You should display all the return values accordingly.


    //user define delegate
    delegate int Arithmetic_Exp(int a, int b);

    public class Calculator_fun
    {
        //Addition
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        //Subtration
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        //Multiplication
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        //Division
        public static int Division(int a,int b)
        {
            return a / b;
        }
  
    }
}
