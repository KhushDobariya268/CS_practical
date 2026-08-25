using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    class StudentDetails 
    {
        public int enrollNO { get; set; }
        public String name { get; set; }
    }
    class Class1_Tutorial3_12
    {
        public static void Tutorial3_12Main(string[] args)
        {
            StudentDetails s = new StudentDetails();

            Console.WriteLine("Enrollment Number: ");
            s.enrollNO = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your name: ");
            s.name = Console.ReadLine();

            Console.WriteLine("--------Student Details--------");
            Console.WriteLine("Enrollment Number: " + s.enrollNO);
            Console.WriteLine("Student Name is: " + s.name);
            Console.ReadLine();
        }
    }
}
