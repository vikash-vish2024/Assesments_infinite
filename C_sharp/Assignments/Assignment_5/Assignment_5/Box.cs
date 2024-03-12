using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    //Write a class Box that has Length and breadth as its members.
    //Write a function that adds 2 box objects and stores in the 3rd. Create a Test class to execute the above.
    class Box
    {
        public int Length { get; set; }
        public int Breadth { get; set; }

        public Box(int Length, int Breadth)
        {
            this.Length = Length;
            this.Breadth = Breadth;
        }

        public Box Add(Box Box2)
        {
            int newLength = Length + Box2.Length;
            int newBreadth = Breadth + Box2.Breadth;
            return new Box(newLength, newBreadth);
        }
    }

    public class Test_Box
    {
        public static void Testing_Box()
        {
            int l1, l2;
            int b1, b2;
            //Getting the value for first Box
            Console.Write("Enter the Length of 1st Box -> ");
            l1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Breadth of 1st Box -> ");
            b1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            //Getting the value of second Box
            Console.Write("Enter the Length of 2nd Box -> ");
            l2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Breadth of 2nd Box -> ");
            b2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            // Creating two Box objects
            Box Box1 = new Box(l1, b1);
            Box Box2 = new Box(l2, b2);

            // Adding the object of two boxes into Third
            Box Box3 = Box1.Add(Box2);

            //Display the values of Box1 & Box2
            Console.WriteLine($"Box 1 -> Length = {Box1.Length}, Breadth = {Box1.Breadth}");
            Console.WriteLine($"Box 2 -> Length = {Box2.Length}, Breadth = {Box2.Breadth}");

            //After adding the Box1 and Box2 the Length and breadth into Box3
            Console.WriteLine($"Result Box -> Length = {Box3.Length}, Breadth = {Box3.Breadth}");
        }
    }
}
