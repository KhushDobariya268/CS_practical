using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
   class Student4
    {
       private int roll_no;
        private string name;

        public Student4(int roll_no, string name) 
        { 
            this.roll_no = roll_no;
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine("Roll No is: " + roll_no);
            Console.WriteLine("Name: " + name);
        }
    }
    class Class_Tutorial3_20
    {
        public static void Tutorial3_20Main(string[] args)
        {
            Student4 s1 = new Student4(101, "khush");
            s1.Display();
            Console.ReadLine();

            Console.WriteLine("Name:- khush dobariya , Enrollment:- 25SOECE13052");

        }
    }
}
