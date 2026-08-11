using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    internal class last_5_digits_into_X
    {
        public static void last_5_digits_into_Xmain()
        {
            Console.Write("Enter Mobile Number: ");
            string mobile = Console.ReadLine();

            if (mobile.Length >= 5)
            {
                string result = mobile.Substring(0, mobile.Length - 5) + "XXXXX";
                Console.WriteLine("Masked Mobile Number: " + result);
            }
            else
            {
                Console.WriteLine("Invalid Mobile Number.");
            }
            Console.WriteLine("name: khush Dobariya");
            Console.WriteLine("enrollment number: 25SOECE13052");
            Console.ReadLine();
        }
    }   
}
