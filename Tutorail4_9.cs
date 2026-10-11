using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    class Class_Tutorial4_9
    {
        public static void Tutorial4_9Main()
        {
            int x = 0;

            try
            {
                int div = 100 / x;
                Console.WriteLine(div);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }

            Console.ReadKey();

            Console.ReadLine();

            Console.WriteLine("Name:- khush dobariya , Enrollment:- 25SOECE13052");
        }
    }
}
