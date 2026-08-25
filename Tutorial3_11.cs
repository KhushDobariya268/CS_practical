using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    class BankAccounts
    {
        private int accNo;
        private string accHolderName;
        private double accBalance;

        public BankAccounts(int ano, string name, double balance)
        {
            accNo = ano;
            accHolderName = name;
            accBalance = balance;
        }

        public void Deposite(double amount)
        {
            accBalance += amount;
            Console.WriteLine("Amount Deposited Successfully");
        }

        public void Withdraw(double amount)
        {
            if (amount > accBalance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                accBalance -= amount;
                Console.WriteLine("Amount Withdrawn Successfully");
            }
        }

        public void BalanceEnquiry()
        {
            Console.WriteLine("---------------Balance Enquiry---------------");
            Console.WriteLine("Account Number: " + accNo);
            Console.WriteLine("Account Holder Name: " + accHolderName);
            Console.WriteLine("Account Balance: " + accBalance);
        }
    }
    internal class P11
    {
        public static void Tutorial3_11Main(string[] args)
        {
            Console.WriteLine("Enter you account number: ");
            int accNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter you account holder name: ");
            string accHolderName = Console.ReadLine();

            Console.WriteLine("Enter you account balance: ");
            double accBalance = Convert.ToDouble(Console.ReadLine());


            BankAccounts b2 = new BankAccounts(accNo, accHolderName, accBalance);
            Console.WriteLine("---------------Accounta Transaction---------------");
            b2.Deposite(4000);
            b2.Withdraw(1000);
            b2.BalanceEnquiry();

        }
    }
}