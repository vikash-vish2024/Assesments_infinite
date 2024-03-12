using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{

    // IStudent interface
    public interface IStudent
    {
        int StudentId { get; set; }
        string Name { get; set; }
        void ShowDetails();
    }

    // Dayscholar class that implements IStudent
    public class Dayscholar : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string TransportMode { get; set; }

        //override showDetails()
        public void ShowDetails()
        {
            Console.WriteLine($"Dayscholar - Student ID: {StudentId}, Name: {Name}, Transport Mode: {TransportMode}");
        }
    }

    //Resident class that implements IStudent
    public class Resident : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string HostelName { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("----Student Details----");
            Console.WriteLine($"Resident - Student ID: {StudentId}, Name: {Name}, Hostel Name: {HostelName}");
        }
    }
    class Student
    {
        public void Test_Student()
        {
            //DayScholar Student
            Console.Write("Enter Dayscholar Student ID -> ");
            int dsId = Convert.ToInt32(Console.ReadLine());
            Console.Write(" DayScholar Student name -> ");
            string dsName = Console.ReadLine();
            Console.Write("Tranportation Mode -> ");
            string dsTm = Console.ReadLine();

            //passing the values Dayscholar class
            var dayscholar = new Dayscholar { StudentId = dsId, Name = dsName, TransportMode = dsTm };
            
            //Resident Student
            Console.Write("Enter Resident Student ID -> ");
            int rsId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Resident Student name -> ");
            string rsName = Console.ReadLine();
            Console.Write("Name of the Hostel -> ");
            string rsHostel = Console.ReadLine();

            //passing the values to resident class
            var resident = new Resident { StudentId = rsId, Name = rsName, HostelName = rsHostel };

            //Display the details of Students
            Console.WriteLine("----Day-Scholar Student----");
            dayscholar.ShowDetails();
            Console.WriteLine();
            Console.WriteLine("----Residential Student----");
            resident.ShowDetails();

        }
    }
}
