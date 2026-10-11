using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    sealed class A1
    {
        public int x;
        public int y;
    }

    class Class_Tutorial4_7
    {
        public static void Tutorial4_7Main(string[] args)
        {
            A1 sc = new A1();

            sc.x = 110;
            sc.y = 150;

            Console.WriteLine("x = {0}, y = {1}", sc.x, sc.y);

            Console.ReadKey();

            Console.ReadLine();
            Console.WriteLine("Name:- khush dobariya , Enrollment:- 25SOECE13052");
        }
    }
}
