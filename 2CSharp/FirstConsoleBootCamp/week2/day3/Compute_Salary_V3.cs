using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day3
{
    internal class Compute_Salary_V3
    {

        static void Mainn()
        {

            List<string> list = new List<string>();

            for (int i = 1; i <= 3; i++)
            {

                Console.Write("Enter Employee Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Employee Salary: ");
                double salary = double.Parse(Console.ReadLine());

               
                double annualSalary = salary * 12;

                list.Add($"Employee name:{name} Salary:{salary} Annual Salary:{annualSalary}");

            }
            foreach (string item in list) 
            {
                Console.WriteLine(item);
                Console.WriteLine();
                
            }




            Console.ReadKey();
        }
    }
}
