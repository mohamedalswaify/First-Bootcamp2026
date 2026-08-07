using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.week4.day1.Emps
{
    internal class EmployeeTest
    {
        static void Mainn(string[] args)
        {
            Employee e1 = new Employee("John Doe", 30, 1000);
            EmployeeBase e2 = new EmployeeBase("Jane Smith", 28, 1000,500);
            EmployeeHour e3 = new EmployeeHour("Mike Johnson", 25, 1000,10,60);

            Console.WriteLine($"{e1.DisplayEmployeeDetails()} ,Annual {e1.CalculateAnnualSalary()}");
            Console.WriteLine($"{e2.DisplayEmployeeDetails()} ,Annual {e2.CalculateAnnualSalary()}");
            Console.WriteLine($"{e3.DisplayEmployeeDetails()} ,Annual {e3.CalculateAnnualSalary()}");


            Console.ReadKey();

        }
    }
}
