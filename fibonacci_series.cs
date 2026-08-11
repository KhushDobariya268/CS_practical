using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    internal class fibonacci_series
    {
        public static void fibonacci_seriesmain()
        {
            Console.Write("Enter the number of terms: ");
            int n = int.Parse(Console.ReadLine());
            int a = 0, b = 1, c;
            Console.WriteLine("Fibonacci Series:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
            }

            Console.ReadLine();
            Console.WriteLine("name: khush Dobariya");
            Console.WriteLine("enrollment number: 25SOECE13052");
        }
    }
}
