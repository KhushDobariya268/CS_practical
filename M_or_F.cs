using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    internal class M_or_F
    {
        public static void M_or_Fmain()
        {
            string name;
            char gender;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your gender (M/F): ");
            gender = Convert.ToChar(Console.ReadLine().ToUpper());

            if (gender == 'M')
            {
                Console.WriteLine("Mr. " + name);
            }
            else if (gender == 'F')
            {
                Console.WriteLine("Ms. " + name);
            }
            else
            {
                Console.WriteLine("Invalid gender! Please enter M or F.");
            }
            Console.WriteLine("name: khush Dobariya");
            Console.WriteLine("enrollment number: 25SOECE13052");
        }
    }
}
