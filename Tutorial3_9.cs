using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    class clock
    {
        private int hour;
        private int minute;
        private int second;

        public clock()
        {
            hour = 0;
            minute = 0;
            second = 0;
        }

        public clock(int h, int m, int s)
        {
            hour = h;
            minute = m;
            second = s;
        }

        public void Increment()
        {
            second++;
            if (second >= 60)
            {
                second = 0;
                minute++;
                if (minute == 60)
                {
                    minute = 0;
                    hour++;
                    if (hour == 24)
                    {
                        hour = 0;
                    }
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("Time : {0:D2}:{1:D2}:{2:D2}", hour, minute, second);
        }
    }

    class TestClock
    {
        public static void Tutorial3_9Main(string[] args)
        {
            clock c = new clock(23, 59, 58);
            c.Display();
            c.Increment();
            c.Display();
            c.Increment();
            c.Display();

            Console.Read();

            Console.WriteLine("Name:- khush dobariya , Enrollment:- 25SOECE13052");
            Console.Read();
        }
    }
}
