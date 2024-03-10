using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concession
{
    public class Ticket_concession
    {
        public static string P_Name { get; set; }
        public static int P_Age { get; set; }

        public static  void Passenger_Details()
        {
            if (P_Age <= 5) { Console.WriteLine($"Little Champ - Free Ticket"); }
            else if (P_Age >= 60) { Console.WriteLine($"---Senior Citizen---\n Total fare is -> {Calculate_Consession(P_Age)} "); }
            else { Console.WriteLine($"---Ticket Booked---\nTotal Fare -> {Calculate_Consession(P_Age)}/-"); }
            Console.WriteLine($"Name of the Passenger -> {P_Name}");
            Console.WriteLine($"Age -> {P_Age}");
        }
        public static int Calculate_Consession(int age)
        {
            int fare = 500;
            if (age <= 5) { return 0; }
            else if (age > 60) { return fare-((fare*30)/100); }
            else return fare;
        }
        static void Main(string[] args)
        {
        }
    }
}
