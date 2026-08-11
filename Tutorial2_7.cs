using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    internal class Tutorial2_7
    {
        class Number
        {
            public void Swap(ref int x, ref int y)
            {
                int temp;
                temp = x;
                x = y;
                y = temp;
            }
        }

        public static void Tutorial2_7Main(string[] args)
        {
            Number no = new Number();

            int a = 1;
            int b = 2;

            Console.WriteLine("Value of a is Before Swap: " + a);
            Console.WriteLine("Value of b is Before Swap: " + b);

            no.Swap(ref a, ref b);

            Console.WriteLine("Value of a is After Swap: " + a);
            Console.WriteLine("Value of b is After Swap: " + b);
        }
    }
}
