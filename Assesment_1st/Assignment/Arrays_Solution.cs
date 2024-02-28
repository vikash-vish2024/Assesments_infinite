using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Arrays_Solution
    {
        public static void Main(String[] args)
        {
            Arrays_Solution arrays_solution = new Arrays_Solution();
            arrays_solution.Array1();
            arrays_solution.Array2();
            arrays_solution.Copy_ElementsofArray();
            Console.Read();


        }
        //Write a  Program to assign integer values to an array  and then print the following
        //a.	Average value of Array elements
        //b.	Minimum and Maximum value in an array 
        public void Array1()
        {
            int [] arr = new int[10];
            int total = 0;
            Console.WriteLine(" Enter 10 Elements of the Array");
            for(int i = 0; i < arr.Length; i++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                arr[i] = m;
                total += arr[i];
            }
            Console.WriteLine("Average value of Array elements : "+(total/10));
            //Minimum and Maximum value in an array
            Console.WriteLine("Min value of the array : "+arr.Min());
            Console.WriteLine("Max value of the array : "+arr.Max());
        }
        //C# to accept ten marks and display the following
        public void Array2()
        {
            int total=0;
            Console.WriteLine("Enter 10 students marks :");
            int[] arr = new int[10];
            for(int i = 0; i < arr.Length; i++)
            {
                int value = Convert.ToInt32(Console.ReadLine());
                arr[i] = value;
                total += arr[i];
            }
            //Sum of all the elements in array
            Console.WriteLine("Total marks :"+total);
            //Avarage of array elements
            Console.WriteLine("Avarage : "+(total/arr.Length));
            //Minimum value of array
            Console.WriteLine("Minimum Marks : "+arr.Min());
            //Maximum value of the array
            Console.WriteLine("Maximum marks : "+arr.Max());
            Array.Sort(arr);
            //	Display marks in ascending order
            Console.WriteLine("______________________________________");
            Console.WriteLine("Array in ascending order");
            for(int i = 0;i < arr.Length; i++)
            {
                Console.Write(arr[i]+"->");
            }
            // Display marks in Descending order
            Console.WriteLine("_______________________________________");
            Console.WriteLine("Array in Descending order");
            for(int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]+"->");
            }
        }
        public void Copy_ElementsofArray()
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            Console.WriteLine("Enter 5 Numbers of array : ");
            for(int i = 0; i < arr1.Length; i++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                arr1[i] = m;
            }
            Console.WriteLine("The elements of First array are : ");
            for(int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i]+" ");
                //copy the elements of first array into second array
                arr2[i] = arr1[i];
            }
            Console.WriteLine();
            // Printing the second array
            Console.WriteLine("Second array");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
        }

    }
}
