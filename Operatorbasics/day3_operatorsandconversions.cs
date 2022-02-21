using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorbasics
{
    class day3_operatorsandconversions
    {
        public void operatorsAndConvertions()
        {
            // operators / * - +
            int a = 5, b = 10, c = 15;
            Console.WriteLine($"add two no:{a + b}");
            Console.WriteLine($"Sub Two no:{b - a}");
            Console.WriteLine($"Mul two no:{a * c}");
            Console.WriteLine($"Div Two no :{c / a}");

            //condetion cheacking < > !
            if (a !=b)
            {
                Console.WriteLine("condition is true");
            }
            else
            {
                Console.WriteLine("condition is false");
            }

            //type casting implicit and Explicit
            int num = 9;
            double myDouble = num;
            Console.WriteLine("-------implicit----:\n"+myDouble);
            double number = 9.22;
            int myInt = (int)number;
            Console.WriteLine("----Explicit manually converting----:\n"+number);

            //combo two operators
            a += 4;
            Console.WriteLine("combo two operators"+a);
            a += b;
            Console.WriteLine("combo two operators" + a);
            a -= c;
            Console.WriteLine("combo two operators" + a);
            //interpolation
            string firstName = "Ameeja";
            string lastName = "cherukuru";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine("interpolation\n:"+name);
            //terinory operatior
            int Number = 20;
            string result = (Number < 18) ? "true" : "false";
            Console.WriteLine("ternary operator:\n"+result);
             
            //postfix and prifix
        }
    }
}
