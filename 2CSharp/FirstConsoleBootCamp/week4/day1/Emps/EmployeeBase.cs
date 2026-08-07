using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.week4.day1.Emps
{
    public class EmployeeBase
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Bonus { get; set; }

        private double _salary;
        public double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value >= 0)
                {
                    _salary = value;
                }
                else
                {
                    Console.WriteLine("Salary cannot be negative.");

                }
            }
        }
        public EmployeeBase(string name, int age, double salary,double bouns)
        {
            Name = name;
            Age = age;
            Salary = salary;
            Bonus = bouns;

        }

        public string DisplayEmployeeDetails()
        {

            return $"Name: {Name}, Age: {Age}, Salary: {Salary}";
        }

        public double CalculateAnnualSalary()
        {
            double annual = _salary * 12;
            return annual;
        }
    }
}
