using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{


        class Student1
        {
            private int enroll;
            private string name;
            private string branch;

            public void AcceptData(int e, string n, string b)
            {
                enroll = e;
                name = n;
                branch = b;
            }
            public void Display()
            {
                Console.WriteLine("----------Student Details----------");
                Console.WriteLine("Enrollment Number: " + enroll);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Branch: " + branch);
            }
        }

        class Class1 
        { 
          public static void Tutorial3_1Main(string[] args)
            {
                Student1 s1 = new Student1();
                Student1 s2 = new Student1();

                s1.AcceptData(101, "khush", "CE");
                s1.Display();

                s2.AcceptData(102, "meet", "IT");
                s2.Display();

                Console.ReadLine();
            }
        }
    }
