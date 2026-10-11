using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
   class Clock
    {
        private int hours;
        private int minutes;
        private int seconds;
        
        public Clock()
        {
            hours = 12;
            minutes = 0;
            seconds = 0;
        }

        public Clock(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }
        
        public void IncrementSeconds()
        {
            seconds++;
            if (seconds == 60)
            {
                seconds = 0;
                minutes++;
                if (minutes == 60)
                {
                    minutes = 0;
                    hours++;
                    if (hours == 24)
                    {
                        hours = 0;
                    }
                }
            }
        }

        public void Display()
        {
            Console.WriteLine($"Time: {hours:D2}:{minutes:D2}:{seconds:D2}");
        }

        public int Gethours()
        {
            return hours;
        }

        public int Getminutes()
        {
            return minutes;
        }

        public int Getseconds()
        {
            return seconds;
        }
    }

    class Program2
    {
        public static void Tutorial3_2main(String[] args)
        {
            Clock clock1 = new Clock();
            Console.Write("Default Time: ");
            clock1.Display();

            Clock clock2 = new Clock(10,59,58);
            Console.Write("Initial Time: ");
            clock2.Display();

            clock2.IncrementSeconds();
            Console.Write("After 1 second:");
            clock2.Display();

            clock2.IncrementSeconds();
            Console.Write("After 2 seconds:");
            clock2.Display();

            Console.WriteLine("Hours : " + clock2.Gethours());
            Console.WriteLine("Minutes : " + clock2.Getminutes());
            Console.WriteLine("Seconds : " + clock2.Getseconds());

            Console.WriteLine("name: khush Dobariya");
            Console.WriteLine("enrollment number: 25SOECE13052");

        }
    }
}
