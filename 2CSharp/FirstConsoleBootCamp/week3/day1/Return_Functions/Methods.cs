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

        public void Compute_Pct2(string name, double mark, double fullMark)
        {



            double percentage = (mark / fullMark) * 100;
            Console.Write($" Student Name:  {name} \nyour  mark is: {mark} \nYour Percentage is:{percentage} %");
        }

        public void Compute_BMI2(string name, double weight, double height)
        {

            double BMI = weight / Math.Pow((height / 100), 2);


            Console.WriteLine($"Patient Name: {name} ");
            Console.WriteLine($"Patient Weight:{weight} ");
            Console.WriteLine($"Patient Height: {height}");
            Console.WriteLine($"Patient BMI: {BMI} ");

        }


    }
}
