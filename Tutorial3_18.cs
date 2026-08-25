using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    class Employee2
    {
        public string Name { get; set; }

        public double Salary { get; set; }

        public virtual void GenerateSalarySlip()
        {
            Console.WriteLine("Employee Salary Slip");
        }


    }

    class PermanentEmployee2 : Employee2
    {
        public override void GenerateSalarySlip()
        {
            double hra = Salary * 0.20; // HRA is 20% of salary
            double da = Salary * 0.10; // DA is 10% of salary
            double netSalary = Salary + hra + da;

            Console.WriteLine("Permanent Employee Salary Slip");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Basic Salary: " + Salary);
            Console.WriteLine("HRA: " + hra);
            Console.WriteLine("DA: " + da);
            Console.WriteLine("Net Salary: " + netSalary);

        }
    }

    class ContractEmployee2 : Employee2
    {
        public override void GenerateSalarySlip()
        {
            double netSalary = Salary; // For contract employees, net salary is the same as basic salary
            Console.WriteLine("Contract Employee Salary Slip");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Basic Salary: " + Salary);
            Console.WriteLine("Net Salary: " + netSalary);
        }
    }

    class ContractorEmployee2 : Employee2
    {
        public override void GenerateSalarySlip()
        {
            double netSalary = Salary; // For contract employees, net salary is the same as basic salary
            Console.WriteLine("Contract Employee Salary Slip");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Contract Salary: " + Salary);
        }
    }

    class Class_Tutorial3_18
    {
        public static void Tutorial3_18Main()
        {
            Employee2 employee2;

            employee2 = new PermanentEmployee2();

            employee2.Name = "Khush";
            employee2.Salary = 30000;

            employee2.GenerateSalarySlip();

            employee2 = new ContractEmployee2();
            employee2.Name = "viraj";
            employee2.Salary = 25000;
            employee2.GenerateSalarySlip();

            Console.Read();

        }
    }
}