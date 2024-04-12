using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeManagement
{
    class Program
    {
        public static SqlConnection con = null;
        public static SqlCommand cmd;
        
        public static SqlConnection getConnection()
        {
            con = new SqlConnection("data source=ICS-LT-4QYJ9K3\\SQLEXPRESS;initial catalog=Employeemanagement;" +
                "integrated security=true");
            con.Open();
            return con;
        }

        public static void  InsertDataUsingProc()
        {
            con = getConnection();
            
            try
            {
                    
                Console.WriteLine("-----Employee Adding via Procedure-----\n");
                Console.Write("\tEnter Employee Name: ");
                string ename = Console.ReadLine();
                Console.Write("\n\tEnter Salary: ");
                double sal = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter 'P' or 'C' for permanent or contract: ");
                string Emptype = Console.ReadLine();

                cmd = new SqlCommand("AddEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpName", ename);
                cmd.Parameters.AddWithValue("@Empsal", sal);
                cmd.Parameters.AddWithValue("Emptype", Emptype);
                cmd.ExecuteNonQuery();

                Console.WriteLine("-------Emplyees Details------");
               
            }
                catch(SqlException se)
                {
                    Console.WriteLine("Some error occured..."+se.Message);
                }
                
            
        }

        public static void showEmp()
        {

            con = getConnection();
            cmd = new SqlCommand("SELECT * FROM EDetails", con);
            SqlDataReader dr = cmd.ExecuteReader();
            Console.WriteLine("----Employees Details-----");
            while (dr.Read())
            {
                Console.WriteLine($"Employee ID: {dr[0]}, Name: {dr[1]}, Salary: {dr[2]}, Type: {dr[3]}");
            }
        }

        static void Main(string[] args)
        {
            InsertDataUsingProc();
            showEmp();
            Console.Read();
        }
    }
}
