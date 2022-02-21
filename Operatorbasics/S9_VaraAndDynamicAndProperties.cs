using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorbasics
{
    internal class S9_VaraAndDynamicAndProperties
    {
 
        public void varMethod()
        {
            Console.WriteLine("you are in var");
            var data = "Ameejaa";
            //data = 100;
            foreach(char elements in data)
                Console.WriteLine(elements);

            Console.WriteLine("type of variable is:"+data.GetType());

            Console.WriteLine("you are in dynamic:");
            dynamic name = "Jaaaan";
            //name = 100;
            Console.WriteLine("value is:"+name);

            foreach(dynamic elements in name)
                Console.WriteLine(elements);
            Console.WriteLine("Datatype of Dynamic is:" + data.GetType());
        }
        public void PropertiesMethod()
        {
            Properties properties = new Properties();

            Console.WriteLine("Enter Student Id:");
            properties.studentId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student Name:");
            properties.studentName = Console.ReadLine();

            Console.WriteLine("Enter Student Phone:");
            properties.studentNamePhone = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student City:");
            properties.studentCity = Console.ReadLine();

            Console.WriteLine("Enter Student Address:");
            properties.student_Add = int.Parse(Console.ReadLine());

            Console.WriteLine($"StudentId:{ properties.studentId} \nstudentAddress:{properties.student_Add} \nstudentName:{properties.studentName} \nstudentNamePhone:{properties.studentNamePhone} \nstudentCity{properties.studentCity}");
        }
        //static properties 
        public void staticProperty()
        {
            Console.WriteLine("Plzz enter school: ");
            Properties.school_Name = Console.ReadLine();
            Console.WriteLine("school name is:"+ Properties.school_Name);
        }
    }
    class Properties
    {
        public int studentId { get; set; }
        public string studentName { get; set; }
        public  dynamic  studentNamePhone { get; set; }
        public string studentCity { get; set; }
        public  int studentMarks { get; }
        private int studentAdd;
        public int student_Add
        {
            set
            {
                if (value <= 0)
                    Console.WriteLine("Not allowed");
                else
                    this.studentAdd = value;     
            }
            get
            {
                return this.studentAdd;
            }
        }
        //static properties
        static string schoolName;
        static string schoolAdd;
        public static string school_Name
        {
            get { return schoolName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine("Empty string not allowed");
                else
                    schoolName = value;
            }
        }
        public static string school_Add { get; set; }
    }
}
