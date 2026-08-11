using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    internal class positive_nagative_zero
    {
        public static void positivenagetivemain()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("nagitive");
            }
            else if (n > 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("zero");
            }
        }
    }
}