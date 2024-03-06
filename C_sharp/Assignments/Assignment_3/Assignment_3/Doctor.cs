using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Doctor
    {
        private int regnNo;
        private string name;
        private double feescharged;


        public int RegNo { get; set; }
        public string Name { get; set; }
        public double Feescharged { get; set; }

        // Display doctor information
        public void DisplayInfo()
        {
            Console.WriteLine($"Registration Number: {RegNo}");
            Console.WriteLine($"Doctor Name: {Name}");
            Console.WriteLine($"Fees Charged: {Feescharged}");
        }
    }
    class Solutions
    {
       
    }
}