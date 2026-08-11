using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    internal class Number_To_Word
    {
        public static void numbertowordmain()
        {
            Console.Write("Enter a number (0-9): ");
            String Number = Console.ReadLine();
            foreach (char digit in Number)
            {
                switch (digit)
                {
                    case '0':
                        Console.Write("Zero ");
                        break;
                    case '1':
                        Console.Write("One ");
                        break;
                    case '2':
                        Console.Write("Two ");
                        break;
                    case '3':
                        Console.Write("Three ");
                        break;
                    case '4':
                        Console.Write("Four ");
                        break;
                    case '5':
                        Console.Write("Five ");
                        break;
                    case '6':
                        Console.Write("Six ");
                        break;      
                    case '7':
                        Console.Write("Seven ");
                        break;
                    case '8':
                        Console.Write("Eight ");
                        break;
                    case '9':
                        Console.Write("Nine ");
                        break;
                    default:
                        Console.Write("Invalid ");
                        break;
                }
            }
            Console.ReadLine();
            Console.WriteLine("name: khush Dobariya");
            Console.WriteLine("enrollment number: 25SOECE13052");
        }
    }
}