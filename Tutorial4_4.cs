using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    class StaticVar
    {
        public static int num;

        public StaticVar()
        {
            num++;
        }

        public static int getNum()
        {
            return num;
        }
    }

    class Class_Tutorial4_4
    {
        public static void Tutorial4_4Main(string[] args)
        {
            StaticVar s1 = new StaticVar();
            StaticVar s2 = new StaticVar();
            StaticVar s3 = new StaticVar();

            Console.WriteLine("Variable num: {0}", StaticVar.getNum());

            Console.ReadKey();

            Console.ReadLine();
            Console.WriteLine("Name:- khush dobariya , Enrollment:- 25SOECE13052");

        }
    }
}
