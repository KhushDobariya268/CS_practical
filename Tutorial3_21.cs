using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    class Student5 
    {
        protected int roll_no;
        protected string name;

        public Student5(int roll_no, string name)
        {
            this.roll_no = roll_no;
            this.name = name;
        }  
    }
   
    class StudentDetails1 : Student5 
    {
        private int age;
        public StudentDetails1(int age,string name, int roll_no)
            :base(roll_no,name)
        {
            this.age = age;
        }
        public void Display()
        {
            Console.WriteLine("Roll no:" + roll_no);
            Console.WriteLine("Name:" + name);
            Console.WriteLine("age:" + age);
        }
    }

    class Class_Tutorial3_21
    {
        public static void Tutorial3_21main()
        {
            StudentDetails1 s1 = new StudentDetails1(15, "khush", 19);
            s1.Display();
            Console.ReadLine();

            Console.WriteLine("Name:- khush dobariya , Enrollment:- 25SOECE13052");

        }
    }
}
