using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.week3.day1.Return_Functions
{
    internal class Methods
    {

        public void Hello()
        {
            Console.WriteLine("Mohamed Alswaify");

        }

        public void Sum2(int num1, int num2)
        {
            int res = num1 + num2;
            Console.WriteLine(res);
        }

        public int Sum3(int num1, int num2)
        {
            int res = num1 + num2;
           return(res);
        }


        public void Compute_Sal2(string name, double salary, double bonus)
        {
            double totalSalary = salary + bonus;
            double annualSalary = totalSalary * 12;

            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Bonus: " + bonus);
            Console.WriteLine("Total Salary: " + totalSalary);
            Console.WriteLine("Annual Salary: " + annualSalary);
        }

        public double Compute_Sal3(string name, double salary, double bonus)
        {
            double totalSalary = salary + bonus;
            double annualSalary = totalSalary * 12;

            return (annualSalary);

        }






    }
}
