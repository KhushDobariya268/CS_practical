
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    internal class Tutorial2_12
    {
        public static void Tutorial2_12Main(string[] args)
        {
            int n, search;
            int found = 0;

            Console.WriteLine("Enter size:");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter element {0}:", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter elemenet to search:");
            search = Convert.ToInt32(Console.ReadLine());

            for (int i = 0;i < n; i++)
            {
                if (arr[i] == search)
                {
                    found++;
                    break;
                }
            }
            Console.WriteLine(found);
            Console.ReadLine();

        }
    }
}