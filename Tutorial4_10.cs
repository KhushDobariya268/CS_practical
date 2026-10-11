using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    class MyException : Exception
    {
        public MyException(string str) : base(str)
        {
            Console.WriteLine("User defined exception");
        }
    }

    class Class_Tutorial4_10
    {
        public static void Tutorial4_10Main()
        {
            try
            {
                throw new MyException("my exception generated.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught here: " + e.Message);
            }

            Console.WriteLine("LAST STATEMENT");

            Console.ReadKey();

            Console.ReadLine();

            Console.WriteLine("Name:- khush dobariya , Enrollment:- 25SOECE13052");
        }
    }
}
