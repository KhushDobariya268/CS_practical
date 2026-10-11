using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    abstract class Test
    {
        protected int a;

        public abstract void A();
    }

    class Example1 : Test
    {
        public override void A()
        {
            Console.WriteLine("Example1.A");
            base.a++;
        }
    }

    class Example2 : Test
    {
        public override void A()
        {
            Console.WriteLine("Example2.A");
            base.a--;
        }
    }

    class Class_Tutorial4_6
    {
        public static void Tutorial4_6Main(string[] args)
        {
            Test test1 = new Example1();
            test1.A();

            Test test2 = new Example2();
            test2.A();

            Console.ReadKey();
            Console.WriteLine("Name:- khush dobariya , Enrollment:- 25SOECE13052");

        }
    }
}
