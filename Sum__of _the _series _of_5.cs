using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    internal class Sum__of__the__series__of_5
    {
        public static void sumofseriesof5main()
        {
            int terms, number; 
            int sum = 0;
            int current = 0;
            Console.WriteLine("Enter the number of terms: ");
            terms = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter input number: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= terms; i++)
            {
                current = current * 10 + number;
                Console.Write(current);
                sum += current;

                if (i < terms)
                    Console.Write("+");
            }
            Console.WriteLine("Sum is " + sum);
            Console.ReadLine();
            Console.WriteLine("name: khush Dobariya");
            Console.WriteLine("enrollment number: 25SOECE13052");
        }
    }
}
