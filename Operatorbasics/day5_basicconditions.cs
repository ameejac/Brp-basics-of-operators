using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorbasics
{
    class day5_basicconditions
    {
        public void checkingIf()
        {
            Console.WriteLine("plzz enter the numberber:");
            int numberber = int.Parse(Console.ReadLine());
            if(numberber <= 50)
                Console.WriteLine("you are pass in the exam");
            else if(numberber >=60)
                Console.WriteLine("congrats you are elgible");
            else if(numberber >=50)
                Console.WriteLine("All the best");
            else if(numberber >=35)
                Console.WriteLine("failed");
            else
                Console.WriteLine("Sry,try next time");
        }
        public void checkingIfElse()
        {
            int no1 = 52;
            if (no1 > 50)
            {
                if (no1 < 40)
                    Console.Write("Less");
                else
                    Console.Write("Big");
            }
            else
            {
                if (no1 == 52)
                    Console.WriteLine("Value is Eqaul");
                else
                    Console.WriteLine("Value is NotEqual");
            }

        }
        public void checkingSwitchCase()
        {
            Console.WriteLine("please enter the Week numberber:");
            int weekNo = int.Parse(Console.ReadLine());
            switch (weekNo)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednsday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;

                default: 
                    Console.WriteLine("Enter Valid Week No");
                    break;

            }
        }
        public void switchGroup()
        {
            Console.WriteLine("please enter the numberber:");
            char Charector= Convert.ToChar(Console.ReadLine());
            switch (Charector)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowels");
                    break;
                case 'A':
                    Console.WriteLine("please enter Capitab Letters:");
                    char CapitalChar = Convert.ToChar(Console.ReadLine());
                    switch (CapitalChar)
                    {
                        case 'A':
                        case 'E':
                        case 'I':
                        case 'O':
                        case 'U':
                            Console.WriteLine("capitals is vowel");
                            break;
                        default:
                            Console.WriteLine("capitals is not vowel");
                            break;

                    }
                    break;
            }
        }
        public void BasicProgram()
        {
            Console.WriteLine("1.Prime number,2.Armstorng no,3.Even or Odd number");
            Console.WriteLine("please enter the number:");
            
            int no = int.Parse(Console.ReadLine());
            switch (no)
            {
                case 1:
                    int number, i, m = 0, flag = 0;
                    Console.Write("Enter the numberber to check Prime: ");
                    number = int.Parse(Console.ReadLine());
                    m = number / 2;
                    for (i = 2; i <= m; i++)
                    {
                        if (number % i == 0)
                        {
                            Console.Write("numberber is not Prime.");
                            flag = 1;
                            break;
                        }
                    }
                    if (flag == 0)
                        Console.Write("numberber is Prime.");
                    break;
                case 2:
                    int n, r, sum = 0, temp;
                    Console.Write("Enter the numberber= ");
                    n = int.Parse(Console.ReadLine());
                    temp = n;
                    while (n > 0)
                    {
                        r = n % 10;
                        sum = sum + (r * r * r);
                        n = n / 10;
                    }
                    if (temp == sum)
                        Console.Write("Armstrong numberber.");
                    else
                        Console.Write("Not Armstrong numberber.");
                    break;
                case 3:
                    int num= int.Parse(Console.ReadLine());
                    int quocient = num / 2;
                    if (quocient * 2 == num)
                    {
                        Console.WriteLine("if the number is even:" + num);//even no =2,4,6,8etc
                    }
                    else
                    {
                        Console.WriteLine("if the number is odd:" + num);//odd no is i,3,5,7,11 etc
                    }
                    break;
                default:
                    Console.WriteLine("plzzz enter valid case Number");
                    break;
            }
        }
        public void nameCount()
        {
            string name = "Ameeja";
            char ch = 'e';
            int fre = name.Where(x => (x == ch)).Count();
            Console.WriteLine(fre);
            

        }
    }
}
