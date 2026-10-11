using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    class Employees
    {
      private double salary;

        public void SetSalary(double amount)
        {
           if(amount > 0)
            {
                salary = amount;
            }
            else
            {
                Console.WriteLine("Invalid Salary");
            }
        }

        public double GetSalary()
        {
            return salary;
        }
    }

    class Class1_Tutorial3_14
    {
        public static void Tutorial3_14Main(string[] args)
        {
            Employees emp = new Employees();
            Console.WriteLine("Enter Employee Salary: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            emp.SetSalary(amount);
            Console.WriteLine("Employee Salary is: " + emp.GetSalary());

            Console.WriteLine("Name:- khush dobariya , Enrollment:- 25SOECE13052");
        }
    }
}
