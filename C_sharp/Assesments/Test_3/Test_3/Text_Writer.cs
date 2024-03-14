using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test_3
{
    //Write a program in C# Sharp to append some text to an existing file. If file is not available, then create one. 
    //Hint: (Use the appropriate mode of operation.Use stream writer class)
    class Text_Writer
    {
        public static void File_Writer(string phrase)
        {
            //setting the path for text file
            string file_Path = @"D:\Assesments_infinite\C_sharp\Assesments\Test_3\Vikash.txt"; 

            try
            {
                // use of streamWriter class
                using (StreamWriter writer = new StreamWriter(file_Path, append: true))
                {
                    writer.WriteLine(phrase);
                }

                Console.WriteLine("Successful!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
