using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    internal class Armstrong_no_or_not
    {
        public static void Armstrongmain()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = n;
            while (temp != 0)
            {
                int digit = temp % 10;
                sum += digit * digit * digit;
                temp /= 10;
            }
            if (sum == n)
            {
                Console.WriteLine(n + " is an Armstrong number.");
            }
            else
            {
                Console.WriteLine(n + " is not an Armstrong number.");
            }

            Console.ReadLine();
            Console.WriteLine("name: khush Dobariya");
            Console.WriteLine("enrollment number: 25SOECE13052");

        }
    }
}
