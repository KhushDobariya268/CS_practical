using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    internal class ToggleCase
    {
        public static void togglecasemain()
        {   
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            string toggledStr = "";
            foreach (char c in str)
            {
                if (char.IsUpper(c))
                {
                    toggledStr += char.ToLower(c);
                }
                else if (char.IsLower(c))
                {
                    toggledStr += char.ToUpper(c);
                }
                else
                {
                    toggledStr += c;
                }
            }
            Console.WriteLine("Toggled string: " + toggledStr);
            Console.WriteLine("name: khush Dobariya");
            Console.WriteLine("enrollment number: 25SOECE13052");
        }
    }
}
