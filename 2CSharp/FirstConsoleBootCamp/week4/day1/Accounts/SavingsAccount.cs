using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.week4.day1.Accounts
{
    public class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; }

        public SavingsAccount(string accountNumber, string ownerName, double balance, double interestRate) : base(accountNumber, ownerName, balance)
        {
            InterestRate = interestRate;
        }

        public void ApplyInterest()
        {
            double interest = Balance * InterestRate / 100;
            Balance += interest;
            Console.WriteLine($"Interest Applied: {interest}. New Balance: {Balance}");
        }

    }
}
