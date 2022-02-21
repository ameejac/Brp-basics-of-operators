namespace Operatorbasics
{
    class S6_statementAndExceptions
    {
        string[] name = { "ameeja", "taaniya", "sanah", "sinha", "tanya", "jaaan" };
        public void loopThroughName()
        {
            for(int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]+"");
            }
        }
        public void whileLoop()
        {
            int i = 1;
            Console.WriteLine("Plzzz enter the Number:");
            int num = int.Parse(Console.ReadLine());
            while (num <= 10)
            {
                Console.WriteLine("whileloop Process:"+num *i);
            }

        }
        public void DowhileLoop()
        {
            int i = 1;
            Console.WriteLine("Plzzz enter the Number:");
            int num = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("See the process of Do While:" + num * i);
                i++;
            }
            while (num <= 10);
        }
        public void continueBreak()
        {
            for(int i = 0; i <= 10; i++)
            {
                if (i == 5)
                    // continue;
                    // break;
                    goto terminateProgram;
            }
            terminateProgram:
            Console.WriteLine("completed the excution");
        }
        public void tryCatchMutilecatch()
        {
            try
            {
                int a = 1;
                int b = 0;
                int c = a / b;

                string name = null;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void UserException()
        {
            float num = 20;
            float num1 = 0;
            if (num1 == 0)
            {
                throw new S6_CustomException(S6_CustomException.UserException.INVALID_DATA, "Data is Not Valid");
            }
        }
        public void Naturalnum()
        {
            Console.WriteLine("find the natural numbers:");
            Console.WriteLine("Plzzzz enter the number:");
            int number = int.Parse(Console.ReadLine());
            int i = 1;
          /* for (int i = 1; i <= number; i++)
           {
                Console.WriteLine(""+i);
           }*/
          while(i <= number)
          {
                Console.WriteLine(" "+i);
                i++;
          }
        }
       public void UsingSWithCases()
       {
            Console.WriteLine("Plzzz choose one number"+"1.armstrong,2.Polyndrome,3.PerfectNo");
            int no = int.Parse(Console.ReadLine());
            Console.WriteLine("plz enter the Number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = num;
            switch (no)
            {
                case 1:
                    do
                    {
                        int r = num % 10;
                        sum = sum + (r * r * r);
                        num = num / 10;
                    }
                    while (num > 0);
                    if (temp == sum)
                    {
                        Console.WriteLine("If the Num is Armstong");
                    }
                    else
                    {
                        Console.WriteLine("If the Num is not a Armstong");
                    }
                    break;
                case 2:
                    Console.WriteLine("polyndrome:");
                    while (num > 0)
                    {
                        int remainder = num % 10;
                        sum = (sum * 10) + remainder;
                        num = num / 10;
                    }
                    if (temp == sum)
                        Console.WriteLine("No is Polyndrome");
                    else
                        Console.WriteLine("No is not Polyndrome");
                    break;
                case 3:
                    Console.WriteLine("Perfect number");
                    for(int i = 1; i < num; i++)
                    {
                        if(num % i == 0)
                        {
                            sum = sum + i;
                        }
                    }
                    if(sum==temp)
                        Console.WriteLine("If the no is Perfect no");
                    else
                        Console.WriteLine("If the no is not Perfect no");
                    break;
            }
       }
        public void PerfectNo()
        {
            int num, min, max;
            Console.Write("Enter the min number : ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the max number: ");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Perfect numbers are:");
            for (num = min; num <= max; num++)
            {
               int i = 1;
               int sum = 0;
                while (i < num)
                {
                    if (num % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == num)
                    Console.Write(num+"\t");
            }
            Console.Write("\n");
        }
        public void polindrome()
        {
            Console.WriteLine("plzz enter the min no:");
            int minNo= int.Parse(Console.ReadLine());
            Console.WriteLine("plzz enter the max no:");
            int maxNo = int.Parse(Console.ReadLine());
            for (int num = minNo; num <= maxNo; num++)
            {
               int sum = 0;
                int n = num;
                while (n !=0)
                {
                    int remainder = n % 10;
                    sum = (sum * 10) + remainder;
                   n = n / 10;
                }
                if ( sum==num )
                {
                    Console.WriteLine("if the no is polyndrome:"+sum);
                }
                else
                {
                    Console.WriteLine(sum);
                }
            }
        }
    }
}
