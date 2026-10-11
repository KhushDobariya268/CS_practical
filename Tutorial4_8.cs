using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    class X
    {
        public virtual void F()
        {
            Console.WriteLine("X.F");
        }

        public virtual void F2()
        {
            Console.WriteLine("X.F2");
        }
    }

    class Y : X
    {
        public sealed override void F()
        {
            Console.WriteLine("Y.F");
        }

        public override void F2()
        {
            Console.WriteLine("Y.F2");
        }
    }

    class Z : Y
    {
       

        public override void F2()
        {
            Console.WriteLine("Z.F2");
        }
    }

    class Class_Tutorial4_8
    {
       public static void Tutorial4_8Main()
        {
            X Obj1 = new X();

            Obj1.F();
            Obj1.F2();

            Y Obj2 = new Y();

            Obj2.F();
            Obj2.F2();

            Z Obj3 = new Z();

            Obj3.F();
            Obj3.F2();

            Console.ReadKey();

            Console.ReadLine();
            Console.WriteLine("Name:- khush dobariya , Enrollment:- 25SOECE13052");

        }
    }
}
