using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    internal class Tutorial2_11
    {
        public static void Tutorial2_11Main(string[] args)
        {
            int n , sum = 0;
            Console.WriteLine("Enter element");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter element {0}:", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum is" +  sum);
        }
    }
}
