using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    class Number
    {
        public int getValues(out int x, out int y, out int z)

        {
            Console.WriteLine("Enter First Number :");
            x = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Second Number :");
            y = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Third Number :");
            z = Convert.ToInt32(Console.ReadLine());

            int sum = x + y + z;
           
            return sum;

        }

    }

    internal class Tutorial2_8
    {
        public static void Tutorial2_8Main(string[] args)
        {
            Number no = new Number();
            int a, b, c, sum;

           sum = no.getValues(out a, out b, out c);

            Console.WriteLine("After method call, value of a : {0}", a);

            Console.WriteLine("After method call, value of b : {0}", b);

            Console.WriteLine("After method call, value of c : {0}", c);

            Console.WriteLine("Sum :" + sum);
            Console.ReadLine();
        }       
    }
}
