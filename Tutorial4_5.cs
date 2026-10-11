using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    public class A 

    {

        public A(int value)

        {

            Console.WriteLine("Base constructor A()");

        }

    }



    public class B : A 

    {

        public B(int value) : base(value)

        {

            Console.WriteLine("Derived constructor B()");

        }

    }



    class Class_Tutorial4_5

    {

        public static void Tutorial4_5Main(string[] args)

        {

            A a = new A(0);

            B b = new B(1);

            Console.ReadLine();

            Console.WriteLine("Name:- khush dobariya , Enrollment:- 25SOECE13052");

        }

    }
}
