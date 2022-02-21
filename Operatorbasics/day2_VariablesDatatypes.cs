using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorbasics
{
    class day2_VariablesDatatypes
    {
        //enumeration
        enum Months
        { 
            Jan, Feb, March, April, May, June, July, August, Sepetember, Octobor, November, December 
        };

        // Instance variable is or Non static variable
        int[] numbers = { 1, 2, 3, 4, 5 };

        //Static Variable
        static string[] studentName = {"ameeja","reshu","rehan","sana","taniya","tanya" };

        public void VariablesAndUses()
        {
            //Local Variable...
            int digit = 15;
            Console.WriteLine("Integer Digit " + digit);

            string name = "Hello World";
            Console.WriteLine("Message: " + name);

            //Constant varibale
            const string game = "Holyball";
            //game = "Cricket";
            Console.WriteLine("Event:" + game);

            for (var i = 0; i < studentName.Length; i++)
            {
                Console.Write(studentName[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            foreach (int month in Enum.GetValues(typeof(Months)))
            {
                Console.Write($"{Enum.GetName(typeof(Months), month)}");
                Console.WriteLine($" {month}");
            }

            //escape and verbitram
            string path = " "; //Escape Sequence \t \b \n \' \"" \?
            path = @""; // Verbatim
            Console.WriteLine(path);

            Console.ReadLine();
        }

    }
}
