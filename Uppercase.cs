using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    internal class Uppercase
    {
        public static void uppercasemain()
        {
            // 1 Method

            //Console.Write("Enter a string: ");
            //string str = Console.ReadLine();
            //string upperStr = str.ToUpper();
            //Console.WriteLine("Uppercase string: " + upperStr);

            //2 method
            
            string name;
            Console.Write("Enter name to convert to uppercase:");
            name = Console.ReadLine();
            Console.WriteLine("Uppercase Result is: " + name.ToUpper());
            Console.ReadLine();
            Console.WriteLine("name: khush Dobariya");
            Console.WriteLine("enrollment number: 25SOECE13052");
        }
    }
}
