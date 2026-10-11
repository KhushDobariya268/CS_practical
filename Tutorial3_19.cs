using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    class Students 
    {
        static int count = 0;
        public Students()
        {
            count++;
        }

        public static void DisplayCount()
        {
            Console.WriteLine("Total Number of Students: " + count);
        }
    }
    class Class_Tutorial3_19
    {
        public static void Tutorial3_19Main(string[] args)
        {
            Students s1 = new Students();
            Students s2 = new Students();
            Students s3 = new Students();
            Students s4 = new Students();
            Students.DisplayCount(); 
            Console.ReadLine();
            Console.WriteLine("Name:- khush dobariya , Enrollment:- 25SOECE13052");
        }
    }
}