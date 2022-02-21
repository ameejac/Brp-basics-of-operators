using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorbasics
{
    internal class S8_Callby_Valuesandrefference
    {
        //call by method
        public void PassByvalue_addition(int num)
        {
           num = num + 10;
            Console.WriteLine("value is:"+num);
        }
        public void PassByValue()
        {
            int num1 = 20;
            PassByvalue_addition(num1);
            Console.WriteLine("Inside of pass by value :"+"\n\n"+num1);
        }
        //refference type
        public void PassBRefference_Substrtaction(ref int value)
        {
            value = value - 10;
            Console.WriteLine("substract value is:"+ value);
        }
        public void PassByRefference()
        {
            int numdiv = 30;
            PassBRefference_Substrtaction(ref numdiv);
            Console.WriteLine("inside pass by reffernce is:"+numdiv);
        }
        //PassBy out:key Word
        public void PassByOut_Devide(out int value)
        {
            value = 60;
            Console.WriteLine("Out value is:"+value);
        }
        public void PassByOut()
        {
            int numDevide;
            PassByOut_Devide(out numDevide);
            Console.WriteLine("Inside pass by out is :"+numDevide);
        }
    }
}
