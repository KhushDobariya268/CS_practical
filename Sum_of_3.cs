using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    internal class Sum_of_3
    {
        
            public static void sumof3main()
            {
                Console.Write("Enter 1 Number: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Enter 2 Number: ");
                int b = int.Parse(Console.ReadLine());

                Console.Write("Enter 3 " +
                    "Number: ");
                int c = int.Parse(Console.ReadLine());

            // Addition of 3 numbers
            int ans = a + b + c;

            //Subtraction of 3 numbers
            //int ans = a - b - c;

            // Multiplication of 3 numbers
            //int ans = a * b * c;

            // Division of 3 numbers
            //float ans = a / b / c;

            //

            Console.WriteLine("Sum of 3 Number is: " + ans);
            Console.WriteLine("name: khush Dobariya");
            Console.WriteLine("enrollment number: 25SOECE13052");
        }
        }
    }
