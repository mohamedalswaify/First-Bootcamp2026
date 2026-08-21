using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.week4.day1.Accounts
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string OwnerName { get; set; }
        public double Balance { get; set; }

        public BankAccount(string accountNumber, string ownerName, double balance)
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            Balance = balance;
        }

        public void DisplayAccount()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Owner Name: {OwnerName}, Balance: {Balance}");
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: {amount}. New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }


    }
}
