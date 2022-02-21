using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorbasics
{
    class S7_ArraysAndTypes
    {
        public void SingalDA()
        {
            //Array Creation 
            //int[] number=new int[5];
            //dataType[] variable1 = new dataType[] { "abc","abc","abc"};
            //dataType[] variable2 = { 1.0, 2.0, 3.0, 4.0, 5.0 };
            //dataType[] variabel1, variable2;

            int[] num = new int[5];
            Console.WriteLine($"The Numbers are: {num[0] = 10},{num[1] = 20},{num[2] = 'a'},{num[3] = 'b'},{num[4] = 50}");

            //useforeach
            string[] name = { "sanah", "tanya", "jaan", "taniya", "sinha" };
            Console.WriteLine("Lentgth of Array is:" + name.Length);
            foreach (var elements in name)
            {
                Console.WriteLine("the namesare:" + elements);
            }
            //array values taking from the user
            Console.WriteLine("Please enter the size of array:");
            int userNum = int.Parse(Console.ReadLine());
            int[] arr = new int[userNum];
            for (int i = 0; i < userNum; i++)
            {
                Console.WriteLine("Plzzz enter the data");
                int data = int.Parse(Console.ReadLine());
                arr[i] = data;
            }
            Console.WriteLine("The Final array is:");
            foreach (var elements in arr)
            {
                Console.WriteLine("Data is:" + elements);
            }
        }
        //multi dimensional arrays are Rectangular type array
        //dataType[row,column] variable =new dataType[row,column];
        //dataType[row,column] variable =new dataType[row,column]{ {1,2,3},{4,5,6},{1,2,4} };
        //dataType[row,column] variable ={ {1,2,3},{4,5,6},{1,2,4} };

        //jagged array
        //dataType[row][column] variable =new dataType[row,column] jagged array
        //            0  1   2  3  <<Col
        //   Row>> 0 {12,24,36,48 },      [2,2] ==20
        //         1 {60,72,84,96 },
        //         2 {10,20,20,40 },
        public void multiDA()
        {
            int[,] nums = new int[3, 4]
             {
                {12,24,36,48 }, // Rectangular Array.
                {60,72,84,96 },
                {10,20,30,40 },
             };
            Console.WriteLine($"\nElements of Array is: {nums[1, 2]} \n");
            Console.WriteLine($"Dimension Array is: { nums.GetLength(1)} \t Size of Dimension {nums.Rank} " + "\n");

            Console.WriteLine("forloop:");
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.Write(nums[i, j] + "  ");
                }
            }
            foreach (var i in nums)
            {
                Console.WriteLine(i);
            }
            //jagged array
            int[][] numbers = new int[3][];
            numbers[0] = new[] { 10, 20, 30, 40, 50 };
            numbers[1] = new[] { 10, 20, 30, 40 };
            numbers[2] = new[] { 10, 20, 30 };
            foreach (int[] num in numbers)
            {
                foreach (var i in num)
                {
                    Console.WriteLine("Elements are :" + i);
                }
            }
        }
        public void ArraySortAssending()
        {
            Console.WriteLine("plzz enter the Size of Array:");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];
            Console.WriteLine("\n" + "Plzzz Enter the data:");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine()); ;
            }
            Console.WriteLine("\n");
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (numbers[j] < numbers[i])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            Console.WriteLine("sorting:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        public void Reversearrey()
        {
            int[] arr = new int[] { 50, 10, 30, 40, 20, 60 };
            int temp;
            foreach (int i in arr)
            {
                Console.WriteLine("before sorting:" + i);
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

            }
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
        }
        public void multiDAsorting()
        {
            int[,] nums = new int[3, 4]
             {
                {12,24,36,48 }, // Rectangular Array.
                {60,72,84,96 },
                {10,20,30,40 },
             };
            
            Console.WriteLine("forloop:");
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.Write(nums[i, j] + "  ");
                }
            }
            foreach (var i in nums)
            {
                Console.WriteLine(i);
            }
            Array.Sort(nums);
            foreach (var i in nums)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----revrse multidimensional-----");
            for (int i = 0; i < nums.GetLength(0)-1; i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.Write(nums[i, j] + "  ");
                }
            }
            foreach (var i in nums)
            {
                Console.WriteLine(i);
            }

            Array.Sort(nums);
        }
    }
}
