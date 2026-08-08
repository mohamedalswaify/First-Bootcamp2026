using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.week4.day2.EmpsV2
{
    public class FreeLancer : IEmployee, IPrintable
    {
        public string Name { get; set; }
        public double ProjectPrice { get; set; }

        public FreeLancer(string name, double projectPrice)
        {
            Name = name;
            ProjectPrice = projectPrice;

        }




        public string DisplayEmployeeDetails()
        {
            return $"Name: {Name}, ProjectPrice: {ProjectPrice}";
        }
        public double CalculateAnnualSalary()
        {
            return ProjectPrice * 12;
        }

        public void Hello()
        {
            Console.WriteLine($"Hello, I am {Name}, a freelancer.");

        }

        public void Print()
        {
            Console.WriteLine($"Freelancer Details: {DisplayEmployeeDetails()}");

        }
    }
}
