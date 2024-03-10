using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concession;

namespace Assignment_4
{
    class Calling_Main
    {
        // Ticket Booking and Concession 
        static void Call_Ticket_Booking()
        {
            Console.WriteLine("---Ticket Booking Platform---");
            Console.Write("Enter Passenger Name -> ");
            Ticket_concession.P_Name = Console.ReadLine();
            Console.Write("\nEnter Age of Passenger -> ");
            Ticket_concession.P_Age = int.Parse(Console.ReadLine());
            Ticket_concession.Passenger_Details();
        }

        //Square method calling
        public static void Call_Square()
        {
            Lambda_Queries.Get_List_Numbers();
            Lambda_Queries.Square();
        }
        //Calling return words
        static void Call_Return_Words()
        {
            Lambda_Queries.Get_List_Words();
            Lambda_Queries.Get_List_Words();
        }

        static void Main(string[] args)
        {
            // Ticket Booking and Concession 
            Call_Ticket_Booking();

            //Square method calling
            Call_Square();

            //Calling return words
            Call_Return_Words();
            Console.Read();
        }
    }
}
