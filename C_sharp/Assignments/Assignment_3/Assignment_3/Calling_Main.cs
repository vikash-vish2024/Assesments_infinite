using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Calling_Main
    {
        static void Main()
        {
            //Display first and last name
            String_Upper.get_Name();
            String_Upper.Display();

            //character count output
            Char_Count.get_Data();
            Char_Count.Display();

            //Account output
            Accounts accounts = new Accounts();
            try
            {
                accounts.Update();
                Console.WriteLine("------------Details After Transaction------------");
                accounts.ShowData();
            }
            catch (Insufficient_Bal_Exception bx)
            {
                Console.WriteLine(bx.Message);
            }
            //scholarship output
            Console.Write("Enter the marks: ");
            int marks = int.Parse(Console.ReadLine());
            Console.Write("Enter the Fees: ");
            int fees = int.Parse(Console.ReadLine());
       
            Console.WriteLine($"You will get your scholarship -> {Scholarship.Merit(marks,fees)}");

            //doctor calling
            Doctor doctor = new Doctor();
            Console.Write("Enter the Reegistration No.-> ");
            doctor.RegNo = int.Parse(Console.ReadLine());
            Console.Write("Enter the patient Name -> ");
            doctor.Name = Console.ReadLine();
            Console.Write("Enter the Fees Charged -> ");
            doctor.Feescharged = Convert.ToInt32(Console.ReadLine());
            doctor.DisplayInfo();
        }
      
    }
}
