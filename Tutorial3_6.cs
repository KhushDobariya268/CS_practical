using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    class Line
    {
        private double length;   // Length of a line

        public Line()
        {
            Console.WriteLine("Object is being created, length = 10");

            length = 10;   // Missing statement-1/2
        }

        public void setLength(double len)
        {
            length = len;   // Missing statement-3
        }

        public double getLength()
        {
            return length;   // Missing statement-4
        }
    }

    public class TestLine
    {
        public static void Tutorial3_6Main(string[] args)
        {
            Line line = new Line();

            // set line length
            line.setLength(10);
            Console.WriteLine("Length of line : {0}", line.getLength());

            // set line length
            line.setLength(6);
            Console.WriteLine("Length of line : {0}", line.getLength());
            Console.Read();

            Console.WriteLine("Name:- khush dobariya , Enrollment:- 25SOECE13052");
            Console.Read();
        }
    }
}
