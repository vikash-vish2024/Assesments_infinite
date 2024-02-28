using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_2
{
    class Largest_Int
    {
        public void Largest()
        {
            Console.WriteLine("Enter three integer to get max");
            int[] arr = new int[3];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The largest Number in given values is->"+arr.Max());

        }
       
    }
}
