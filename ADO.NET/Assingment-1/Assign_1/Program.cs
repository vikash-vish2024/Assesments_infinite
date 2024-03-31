using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }
    class Program
    {
        //public static void Populate_Employee_Generic()//method to populate the data into Employee using generic list
        //{
        //    List<Employee> emp = new List<Employee>
        //    {
        //    new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 6, 8), City = "Mumbai" },
        //    new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
        //    new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" },
        //    new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
        //    new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
        //    new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
        //    new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Mumbai" },
        //    new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" },
        //    new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 12, 3), City = "Chennai" },
        //    new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 1, 2), City = "Pune" }
        //    };
        //}
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>
            {
            new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 6, 8), City = "Mumbai" },
            new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
            new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" },
            new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
            new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
            new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
            new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Mumbai" },
            new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" },
            new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 12, 3), City = "Chennai" },
            new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 1, 2), City = "Pune" }
            };
            //Populate_Employee_Generic();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
        
            //1.Display a list of all the employee who have joined before 1 / 1 / 2015
            var JoinBefore = emp.Where(x => x.DOJ < new DateTime(2015, 01, 01));
            Console.WriteLine($"list of all the employee who have joined before 01/01/2015 -> {JoinBefore.Count()}");
            foreach (var v in JoinBefore)
                Console.WriteLine(v.FirstName+" "+v.LastName);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
            
            //2.Display a list of all the employee whose date of birth is after 1 / 1 / 1990
            var DOBAfter = emp.Where(x => x.DOB < new DateTime(1990, 01, 01));
            Console.WriteLine($"list of all the employee whose date of birth is after 01/01/1990 -> {DOBAfter.Count()}");
            foreach (var v in DOBAfter)
                Console.WriteLine(v);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
            
            //3.Display a list of all the employee whose designation is Consultant and Associate
            var DesignationAs = emp.Where(x => x.Title.Equals("Consultant") || x.Title.Equals("Associate"));
            Console.WriteLine($"list of all the employee whose designation is Consultant and Associate -> {DesignationAs.Count()}");
            foreach(var v in DesignationAs)
                Console.WriteLine(v.FirstName+" "+v.LastName);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
            
            //4.Display total number of employees
            Console.WriteLine($"Count of Employees ->{emp.Count()}");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
            
            //5.Display total number of employees belonging to “Chennai”
            var BelongtoCity = emp.Where(x => x.City.Equals("Chennai"));
            Console.WriteLine($"total number of employees belonging to “Chennai” -> {BelongtoCity.Count()}");
            foreach(var v in BelongtoCity)
                Console.WriteLine(v.FirstName+" "+v.LastName+" ->"+v.City);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
            
            //6.Display highest employee id from the list
            Console.WriteLine("highest employee id from the list");
            Console.WriteLine(emp.Max(x => x.EmployeeID));
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
            
            //7.Display total number of employee who have joined after 1 / 1 / 2015
            var EmployeeJoinAfter = emp.Where(x => x.DOJ > new DateTime(2015, 01, 01));
            Console.WriteLine(" total number of employee who have joined after 1 / 1 / 2015 ->"+EmployeeJoinAfter.Count());
            foreach(var v in EmployeeJoinAfter)
                Console.WriteLine(v.FirstName+" "+v.LastName+" "+v.DOJ);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
            
            //8.Display total number of employee whose designation is not “Associate”
            var DesignatioNot = emp.Where(x => x.Title != "Associate");
            Console.WriteLine($"total number of employee whose designation is not “Associate” -> {DesignatioNot.Count()}");
            foreach(var v  in DesignatioNot)
                Console.WriteLine(v.FirstName+" "+v.LastName+" ->"+v.Title);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");

            //9.Display total number of employee based on City
            var BasedOnCity = emp.GroupBy(x => x.City).Select(group => new { City = group.Key, EmpCount = group.Count() });
            Console.WriteLine("total number of employee based on City");
            foreach(var v in BasedOnCity)
                Console.WriteLine(v.City+" "+v.EmpCount);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");

            //10.Display total number of employee based on city and title
            var BasedOnCity_Title = emp.GroupBy(x => new { x.City, x.Title }).Select(group => new { city = group.Key.City, Title = group.Key.Title, empcount = group.Count() });
            Console.WriteLine("total number of employee based on city and title");
            foreach(var v in BasedOnCity_Title)
                Console.WriteLine(v.city+" "+v.Title+" "+v.empcount);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");

            //11.Display total number of employee who is youngest in the list
            DateTime youngestDOB = emp.Max(x => x.DOB);
            var youngestEmp = emp.Where(x => x.DOB.Equals(youngestDOB));
            Console.WriteLine("employee who is youngest in the list");
            foreach(var v in youngestEmp)
                Console.WriteLine(v.FirstName+" "+v.LastName+" "+v.DOB);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");

            Console.Read();
        }
    }
}
