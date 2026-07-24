using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day2
{
    internal class Compute_salary_V2
    {
        static void Mainn(string[] args)
        {

            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Employee Salary: ");
            double salary = double.Parse(Console.ReadLine());

            Console.Write("Enter Employee Bonus: ");
            double bonus = double.Parse(Console.ReadLine());

            double totalSalary = salary + bonus;
            double annualSalary = totalSalary * 12;


            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Bonus: " + bonus);
            Console.WriteLine("Total Salary: " + totalSalary);
            Console.WriteLine("Annual Salary: " + annualSalary);



            if (annualSalary >= 12000)
            {
                Console.WriteLine("High Salary");
            }
            else if(annualSalary >= 6000)
            {
                Console.WriteLine("Normal Salary");
            }
            else if (annualSalary >= 3000)
            {
                Console.WriteLine("Low Salary");
            }

            else
            {

                Console.WriteLine("Very Low Salary");
            }





            Console.ReadKey(true);
        }
    }
}
