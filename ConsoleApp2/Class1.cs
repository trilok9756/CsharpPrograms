using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BankAccount
    {
        public string AccountNumber;
        public string AccountHolderName;
        public double Balance;

        public BankAccount(string accountNumber, string accountHolderName, double initialBalance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = initialBalance;
        }

        // Deposit
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited ${amount}. New balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }
        }

        // withdraw money
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn ${amount}. New balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Withdrawal amount is invalid or exceeds the balance.");
            }
        }

        // display details 
        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Balance: ${Balance}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("123456789", "Chandarmauli", 1000);

            Console.WriteLine("Account Details:");
            account1.DisplayAccountDetails();

            account1.Deposit(500);

            account1.Withdraw(200);

            Console.WriteLine("Updated Account Details:");
            account1.DisplayAccountDetails();
            Console.ReadLine();
        }
    }
}