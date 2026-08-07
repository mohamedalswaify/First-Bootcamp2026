using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.week4.day1.Accounts
{
    public class CurrentAccount : BankAccount
    {

        public double OverdraftLimit { get; set; }

       public CurrentAccount(string accountNumber, string ownerName, double balance, double overdraftLimit)  :base(accountNumber, ownerName, balance)
        {
            OverdraftLimit = overdraftLimit;

        }

        public void Withdraw(double amount)
        {
            if (amount > 0 &&  amount<= Balance )
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}. New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Withdrawal amount exceeds overdraft limit or is not positive.");
            }
        }
    }
}
