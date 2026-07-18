using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp
{
    internal class Compute_salary
    {

        static void Main(string[] args)
        {

            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Employee Salary: ");
            double salary =  double.Parse(Console.ReadLine())  ;

            Console.Write("Enter Employee Bonus: ");
            double bonus =double.Parse(Console.ReadLine());

            double totalSalary = salary + bonus;
            double annualSalary = totalSalary * 12;


            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Bonus: " + bonus);
            Console.WriteLine("Total Salary: " + totalSalary);
            Console.WriteLine("Annual Salary: " + annualSalary);


            //Compute_BMI 

            // Enter Patient Name:
            // Enter Patient Weight: 87
            // Enter Patient Height: 187


            // BMI = weight / (height / height)  ** 2


            // print Patient Name:
            //print Patient Weight:
            // print Patient Height:
            // print Patient BMI: 18 - 30





            Console.ReadKey(true);
        }
    }
}
