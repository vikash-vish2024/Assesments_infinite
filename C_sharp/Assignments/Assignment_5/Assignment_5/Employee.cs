using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }

        public Employee(int empId, string empName, double salary)
        {
            EmpId = empId;
            EmpName = empName;
            Salary = salary;
        }
    }

    class Part_Time_Employee : Employee
    {
        public float Wages { get; set; }

        public Part_Time_Employee(int empId, string empName, double salary, float wages): base(empId, empName, salary)
        {
            Wages = wages;
        }
        
    }

    class Test_Emp
    {
        public static void Set_Dis_Emp()
        {
            // Create an Employee instance and passing the values

            Console.Write("Enter The Employee Id -> ");
            int empid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name -> ");
            string eName = Console.ReadLine();
            Console.Write("Enter Employee Salary ->");
            double eSal = Convert.ToDouble(Console.ReadLine());

            Employee employee = new Employee(empId: empid, empName: eName, salary: eSal);

            Console.WriteLine();

            // Create a ParttimeEmployee instance and passing the values\

            Console.Write("Enter Part Time Employee ID -> ");
            int empid2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Part Time Employee Name -> ");
            string eName2 = Console.ReadLine();
            Console.Write("Enter Part Time Employee Salary -> ");
            double eSal2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Part Time Employee Wages -> ");
            //float wg = int.Parse(Console.ReadLine());
            float wg = Convert.ToSingle(Console.ReadLine());

            Part_Time_Employee part_Time_Employee = new Part_Time_Employee(empId: empid2, empName: eName2, salary: eSal2, wages: wg);

            //Details of Employee
            Console.WriteLine($"Employee ID: {employee.EmpId}, Employee Name: {employee.EmpName}, Employee Salary: {employee.Salary}");
            Console.WriteLine();

            //Details of Part-Time Employee
            Console.WriteLine($"Part-time Employee ID : {part_Time_Employee.EmpId}, Part-time Employee Name: {part_Time_Employee.EmpName}" +
                $", Part-time Employee Salary: {part_Time_Employee.Salary}, Part-time Employee Wages: {part_Time_Employee.Wages}  ");

        }

    }
}
