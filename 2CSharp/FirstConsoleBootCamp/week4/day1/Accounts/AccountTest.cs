using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.week4.day1.Accounts
{
    internal class AccountTest
    {
        static void Main(string[] args)
        {
            //// Create instances of BankAccount, SavingsAccount, and CurrentAccount
            //BankAccount bankAccount = new BankAccount("BA123", "John Doe", 1000);
            //SavingsAccount savingsAccount = new SavingsAccount("SA456", "Jane Smith", 2000, 5);
            //CurrentAccount currentAccount = new CurrentAccount("CA789", "Alice Johnson", 1500, 500);

            //// Display account details
            //bankAccount.DisplayAccount();
            //savingsAccount.DisplayAccount();
            //currentAccount.DisplayAccount();

            //// Deposit money
            //bankAccount.Deposit(500);
            //savingsAccount.Deposit(300);
            //currentAccount.Deposit(200);

            //// Calculate interest for savings account
            //savingsAccount.ApplyInterest();

            //// Withdraw money from current account
            //currentAccount.Withdraw(1000);




            IList<BankAccount> accounts = new List<BankAccount>
                {
              new BankAccount("BA123", "John Doe", 1000),
                new SavingsAccount("SA456", "Jane Smith", 2000, 5),
                new CurrentAccount("CA789", "Alice Johnson", 1500, 500)
            };

            foreach (var account in accounts)
            {
                account.DisplayAccount();
                account.Deposit(500);
                if (account is SavingsAccount savingsAccount)
                {
                    savingsAccount.ApplyInterest();
                }
                else if (account is CurrentAccount currentAccount)
                {
                    currentAccount.Withdraw(1000);
                }
                Console.WriteLine("===================================");
            }




            Console.ReadKey();


       
        }
    }
}
