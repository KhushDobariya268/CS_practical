using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    class Student2
    {
        public String course { get; set; }
        public String department { get; set; }
        public void DisplayStudentDetails()
        {
            Console.WriteLine("--------Student Details--------");
            Console.WriteLine("Course: " + course);
            Console.WriteLine("Department: " + department);
        }
    }
    class Person : Student2
    {
        public String name { get; set; }
        public int Age { get; set; }
        public void DisplayPersonDetails()
        {
            Console.WriteLine("--------Person Details--------");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + Age);
        }
    }

    class Class1_Tutorial3_15
    {
        public static void Tutorial3_15Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine("Enter name of the person:");
            p.name = Console.ReadLine();

            Console.WriteLine("Enter age of person:");
            p.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter course of the student:");
            p.course = Console.ReadLine();

            Console.WriteLine("Enter department of the student:");
            p.department = Console.ReadLine();

            p.DisplayPersonDetails();
            p.DisplayStudentDetails();

        }
    }
}
