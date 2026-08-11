using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    internal class pattern_like_a_diamond
    {
        public static void patternlikeadiamondmain()
        {
            int i, j, n;
            Console.Write("Enter the number of rows: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = i; j < n; j++)
                    Console.Write(" ");
                for (j = 1; j <= (2 * i - 1); j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            for (i = n - 1; i >= 1; i--)
            {
                for (j = n; j > i; j--)
                    Console.Write(" ");
                for (j = 1; j <= (2 * i - 1); j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
