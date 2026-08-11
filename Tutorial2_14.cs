using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    internal class Tutorial2_14
    {
        public static void Tutorial2_14Main(string[] args)
        {
           int maths , physics, chemistry;
            
            Console.WriteLine("Enter marks of Maths:");
            maths = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter marks of Physics:");
            physics = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter marks of Chemistry:");
            chemistry = Convert.ToInt32(Console.ReadLine());
            
            int total = maths + physics + chemistry;
            int mathPhy = maths + physics;

            if (maths >= 65 && physics >= 55 && chemistry >= 50 && total >= 180 && mathPhy >= 140)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
            Console.ReadLine();
        }
    }
}
