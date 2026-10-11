using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    class Employee1
    {
        private int emp_code;
        private string name;

        private string designation;

        private double basicsalary;

        public Employee1(int e, string n, string d, double b)
        {
            emp_code = e;
            name = n;
            designation = d;
            basicsalary = b;
        }

        public void CalculatePay()
        {
            double hra = 0.10 * basicsalary;
            double da = 0.45 * basicsalary;
            double netsalary = basicsalary + hra + da;

            Console.WriteLine("Employee Code: " + emp_code);
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Designation: " + designation);
            Console.WriteLine("Basic Salary: " + basicsalary);
            Console.WriteLine("Net Salary: " + netsalary);
        }
    }
    class Class_Tutorial4_1
    {
        public static void Tutorial4_1Main(string[] args)
        {

            Employee1 emp1 = new Employee1(101, "khush", "Manager", 50000);
            emp1.CalculatePay();

            Employee1 emp2 = new Employee1(102, "viraj", "Developer", 40000);
            emp2.CalculatePay();
            Console.ReadLine();

            Console.WriteLine("Name:- khush dobariya , Enrollment:- 25SOECE13052");

        }
    }
}
