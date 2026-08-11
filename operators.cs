using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    internal class operators
    {
        public static void operatorsmain()
        {
            int a, b;
            Console.WriteLine("Enter a:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("------------Arithmetic Operator-----------");
            Console.WriteLine("Addition is" + (a + b));
            Console.WriteLine("Subtraction is" + (a + b));
            Console.WriteLine("Multiplication is" + (a * b));
            Console.WriteLine("Division is" + (a / b));

            Console.WriteLine("------------Relational Operator-----------");
            Console.WriteLine("a<b" + (a < b));
            Console.WriteLine("a>b" + (a > b));
            Console.WriteLine("a==b" + (a == b));
            Console.WriteLine("a!=b" + (a != b));

            Console.WriteLine("------------Logical Operator-----------");
            Console.WriteLine("a<b && a>b" + (a < b && a > b));
            Console.WriteLine("a<b || a>b" + (a < b || a > b));
            Console.WriteLine("!(a==b)" + !(a == b));

            Console.ReadLine();

        }
    }
}
