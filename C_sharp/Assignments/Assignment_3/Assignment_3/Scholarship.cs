using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Scholarship
    {
        public static int Merit(int marks, int fees)
        {
            if (marks >= 70 && marks <= 80)
            {
                fees = (fees * 20) / 100;

            }
            else if (marks > 80 && marks <= 90)
            {
                fees = (fees * 30) / 100;
            }
            else if (marks > 90)
            {
                fees = (fees * 90) / 100;
            }
            return fees;
        }
    }
}
