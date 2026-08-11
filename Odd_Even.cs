using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    internal class Odd_Even
    {
        public static void evenoddmain()
        {
            int x;

            Console.Write("Enter Number: ");
            string str = Console.ReadLine();

            x = Convert.ToInt32(str);

            if (x % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }

            Console.Read();
            Console.WriteLine("name: khush Dobariya");
            Console.WriteLine("enrollment number: 25SOECE13052");

        }
    }
}
