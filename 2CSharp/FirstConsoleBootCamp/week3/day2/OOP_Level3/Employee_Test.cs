using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.week3.day2.OOP_Level3
{
    internal class Employee_Test
    {
        //Student Student_Test Get_Grade
        static void Mainn(string[] args)
        {

            Employee e1 = new Employee("Ali",1000,200);

            //e1.Salary = -1200;
            e1.Set_Salary(-1200);

            double annualSalary = e1.Compute_Sal();
           string status=  e1.Get_Satus(annualSalary);

            Console.WriteLine($"Employee Name: {e1.Name}");
            Console.WriteLine($"Employee Salary: {e1.Get_Salary()}");
            Console.WriteLine($"Employee Bonus: {e1.Bonus}");
            Console.WriteLine($"Employee Annual Salary: {annualSalary}");
            Console.WriteLine($"Employee Status: {status}");



            Console.ReadKey();
        }
    }
}
