using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    class Employees1
    {
        public int EmployeeId { get; set; }
        public String Name { get; set; }
        public double BasicSalary { get; set; }
    }

    class PermanentEmployee : Employees1
    {
        public void CalculateSalary()
        {
            double HRA = 0.1 * BasicSalary;
            double DA = 0.2 * BasicSalary;
            double netSalary = BasicSalary + HRA + DA;

            Console.WriteLine("--------Permanent Employee Salary Details--------");
            Console.WriteLine("Employee ID: " + EmployeeId);
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Basic Salary: " + BasicSalary);
            Console.WriteLine("HRA: " + HRA);
            Console.WriteLine("DA: " + DA);
            Console.WriteLine("Net Salary: " + netSalary);
        }
    }

    class ContractEmployee : Employees1
    {
        public void CalculateSalary()
        {
            double netSalary = BasicSalary;
            Console.WriteLine("--------Contract Employee Salary Details--------");
            Console.WriteLine("Employee ID: " + EmployeeId);
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Basic Salary: " + BasicSalary);
            Console.WriteLine("Net Salary: " + netSalary);
        }
    }

    class Class1_Tutorial3_16
    {
        public static void Tutorial3_16Main(string[] args)
        {
            PermanentEmployee p = new PermanentEmployee();

            p.EmployeeId = 101;
            p.Name = "khush";
            p.BasicSalary = 50000;
            p.CalculateSalary();

            ContractEmployee c = new ContractEmployee();
            c.EmployeeId = 102;
            c.Name = "viraj";
            c.BasicSalary = 50000;
            c.CalculateSalary();

            Console.Read();
            Console.WriteLine("Name:- khush dobariya , Enrollment:- 25SOECE13052");
        }
    }
}
