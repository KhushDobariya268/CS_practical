using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    class Shape
    { 
    private double area;
        public virtual void CalculateArea()
        {
            Console.WriteLine("AREA of SHAPE");
        }
    }

    class Circle : Shape
    {
        public override void CalculateArea()
        {
            double radius = 5;
            double area = 3.14 * radius * radius;
            Console.WriteLine("AREA of CIRCLE: " + area);
        }
    }

    class Rectangle : Shape
    {
        public override void CalculateArea()
        {
            double length = 10;
            double width = 20;
            double area = length * width;
            Console.WriteLine("AREA of RECTANGLE: " + area);
        }
    }

    class Triangle : Shape
    {
        public override void CalculateArea()
        {
            double baseLength = 10;
            double height = 20;
            double area = 0.5 * baseLength * height;
            Console.WriteLine("AREA of TRIANGLE: " + area);
        }
    }

    class Class1_Tutorial3_17
    { 
     public static void Tutorial3_17Main(string[] args)
        {
            Shape shape;

            shape = new Circle();
            shape.CalculateArea();

            shape = new Rectangle();
            shape.CalculateArea();  

            shape = new Triangle();
            shape.CalculateArea();

            Console.ReadLine();
        }
    }
}
