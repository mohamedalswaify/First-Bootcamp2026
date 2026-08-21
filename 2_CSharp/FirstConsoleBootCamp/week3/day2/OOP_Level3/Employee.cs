using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.week3.day2.OOP_Level3
{
    public class Employee
    {

        public string Name;
        private double Salary;
        public double Bonus;

        //ctor
        public Employee(string name, double salary, double bonus)
        {
            Name = name;
            Salary = salary;
            Bonus = bonus;

        }

        public double Get_Salary()
        {
            return Salary;
        }

        public void Set_Salary(double salary)
        {
            if(salary>=0)
            {
                Salary = salary;
            }
            else
            {
                Console.WriteLine("Salary cannot be negative. Salary not updated.");
            }


        }



        public double Compute_Sal()
        {
            double totalSalary = Salary + Bonus;
            double annualSalary = totalSalary * 12;

            return annualSalary;
        }

        public string Get_Satus(double annual)
        {

            if (annual >= 12000)
            {
               return("High Salary");
            }
            else if (annual >= 6000)
            {
                return ("Normal Salary");
            }
            else if (annual >= 3000)
            {
                return ("Low Salary");
            }
            else
            {

                return ("Very Low Salary");
            }

        }


    }
}
