using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.week4.day2.Empsv2
{
    public class EmployeeBase : Employee
    {
    
        public double Bonus { get; set; }

        public EmployeeBase(string name, int age, double salary,double bouns) : base(name, age, salary)
        { 
            Bonus = bouns;
        }

        public override string DisplayEmployeeDetails()
        {

            return base.DisplayEmployeeDetails() + $"Bouns: {Bonus}";
        }


        public override double CalculateAnnualSalary()
        {
            double annual = (Salary+ Bonus) * 12;
            return annual;
        }


    }
}
