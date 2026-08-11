using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    class Employee
    {

        private int employeeId;
        private string name;
        private double basicSalary;
        private double hra;
        private double da;
        private double netSalary;

        public Employee(int id, string nm, double basic)
        {
            employeeId = id;
            name = nm;
            basicSalary = basic;
        }

        public void CalculateSalary()
        {
            hra = basicSalary * 0.20;
            da = basicSalary * 0.10;

            netSalary = basicSalary + hra + da;
        }

        public void Display()
        {
            Console.WriteLine("\n---------- Employee Details ----------");
            Console.WriteLine("Employee ID   : " + employeeId);
            Console.WriteLine("Name          : " + name);
            Console.WriteLine("Basic Salary  : " + basicSalary);
            Console.WriteLine("Net Salary    : " + netSalary);
        }
    }

    class TestEmployee
    {
        public static void Tutorial3_10Main(string[] args)
        {
            Console.Write("Enter Employee ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            string nm = Console.ReadLine();

            Console.Write("Enter Basic Salary: ");
            double basic = Convert.ToDouble(Console.ReadLine());

            Employee emp = new Employee(id, nm, basic);

            emp.CalculateSalary();


            emp.Display();

            Console.ReadKey();

            Console.Read();

            Console.WriteLine("Name:- khush dobariya , Enrollment:- 25SOECE13052");
            Console.Read();
        }
    }
}
