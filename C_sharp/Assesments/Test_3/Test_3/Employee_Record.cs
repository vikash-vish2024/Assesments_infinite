using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_3
{
    //Create a Generic List Collection empList and populate it with the following records.
    //a. Display detail of all the employee
    // b.Display details of all the employee whose location is not Mumbai
    //c.Display details of all the employee whose title is AsstManager
    //d.Display details of all the employee whose Last Name start with S


    class Employee_Record
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }

    class Employees
    {
        public static void Emp_Records()
        {
            // Create a list of Employee objects
            List<Employee_Record> empList = new List<Employee_Record>
            {
                new Employee_Record { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 06, 08), City = "Mumbai" },
               
                new Employee_Record { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 08, 20), DOJ = new DateTime(2012, 07, 07), City = "Mumbai" },
                
                new Employee_Record { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 04, 12), City = "Pune" },
                
                new Employee_Record { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 06, 03), DOJ = new DateTime(2016, 02, 02), City = "Pune" },
                
                new Employee_Record { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 03, 08), DOJ = new DateTime(2016, 02, 02), City = "Mumbai" },
                
                new Employee_Record { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 07), DOJ = new DateTime(2014, 08, 08), City = "Chennai" },
                
                new Employee_Record { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1980, 12, 02), DOJ = new DateTime(2015, 06, 01), City = "Mumbai" },
                
                new Employee_Record { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1989, 11, 11), DOJ = new DateTime(2014, 11, 06), City = "Chennai" },
                
                new Employee_Record { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 08, 12), DOJ = new DateTime(2014, 12, 03), City = "Chennai" },
                
                new Employee_Record { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 04, 12), DOJ = new DateTime(2016, 01, 02), City = "Pune" }
            };

            //a. Display detail of all the employee

            Console.WriteLine("-----All Employee Records-----");

            foreach (var emp in empList)
            {
                Console.WriteLine($"Employee ID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
            }



            // b.Display details of all the employee whose location is not Mumbai
            Console.WriteLine("-----Location Not Mumbai-----");
            var L_N_Mumbai = empList.Where(emp => emp.City != "Mumbai");
            foreach(var emp in L_N_Mumbai)
            {
                Console.WriteLine($"Employee ID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
            }

            //c.Display details of all the employee whose title is AsstManager
            Console.WriteLine("-----Assistance Manager-----");
            var Asst_Manager = empList.Where(emp => emp.Title == "AsstManager");
            foreach(var emp in Asst_Manager)
            {
                Console.WriteLine($"Employee ID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
            }

            //d.Display details of all the employee whose Last Name start with S
            Console.WriteLine("-----Last Name Start With S-----");
            var l_Name_Start_S = empList.Where(emp => emp.LastName.StartsWith("S"));
            foreach(var emp in l_Name_Start_S)
            {
                Console.WriteLine($"Employee ID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
            }

        }
    }

}