using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.week3.day1
{
    internal class Methods
    {


        public void Sum()
        {
            Console.WriteLine("Enter num1: ");
             int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter num1: ");
            int num2 = int.Parse(Console.ReadLine());


            int res = num1 + num2;
            Console.WriteLine(res);
        }


        public void Sum2(int num1, int num2)
        {
            int res = num1 + num2;
            Console.WriteLine(res);
        }
        public void Compute_Sal()
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


        }


        public void Compute_Sal2(string name,double salary, double bonus)
        {
            double totalSalary = salary + bonus;
            double annualSalary = totalSalary * 12;

            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Bonus: " + bonus);
            Console.WriteLine("Total Salary: " + totalSalary);
            Console.WriteLine("Annual Salary: " + annualSalary);
        }


        public void Compute_Pct()
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Student Mark:");
            double mark = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student Full Mark:");
            double fullMark = double.Parse(Console.ReadLine());


            double percentage = (mark / fullMark) * 100;
            Console.Write($" Student Name:  {name} \nyour  mark is: {mark} \nYour Percentage is:{percentage} %");

            // pct >= 50 pass
            // pct >=85  Excellent
            //pct < 50 fail
            // pct >= 65 Good
            // pct >= 75 Very Good
            if (percentage >= 85)
            {
                Console.WriteLine("Excellent");
            }

            else if (percentage >= 75)
            {
                Console.WriteLine("Very Good");
            }
            else if (percentage >= 65)
            {
                Console.WriteLine("Good");
            }
            else if (percentage >= 50)
            {
                Console.WriteLine("Pass");
            }

            else
            {

                Console.WriteLine("Fail");
            }
        }


        public void Compute_Pct2(string name, double mark, double fullMark)
        {
           


            double percentage = (mark / fullMark) * 100;
            Console.Write($" Student Name:  {name} \nyour  mark is: {mark} \nYour Percentage is:{percentage} %");

            // pct >= 50 pass
            // pct >=85  Excellent
            //pct < 50 fail
            // pct >= 65 Good
            // pct >= 75 Very Good
            if (percentage >= 85)
            {
                Console.WriteLine("Excellent");
            }

            else if (percentage >= 75)
            {
                Console.WriteLine("Very Good");
            }
            else if (percentage >= 65)
            {
                Console.WriteLine("Good");
            }
            else if (percentage >= 50)
            {
                Console.WriteLine("Pass");
            }

            else
            {

                Console.WriteLine("Fail");
            }
        }


        public void Compute_BMI()
        {
            Console.Write("Enter Patient Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Patient Weight: ");
            double weight = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter Patient Height: ");
            double height = double.Parse(Console.ReadLine());

            double BMI = weight / Math.Pow((height / 100), 2);


            Console.WriteLine($"Patient Name: {name} ");
            Console.WriteLine($"Patient Weight:{weight} ");
            Console.WriteLine($"Patient Height: {height}");
            Console.WriteLine($"Patient BMI: {BMI} ");



            //<18.5 underweight
            //>=25  <30 overweight
            //>=18.5 <25 normal  weight
            //>=30 obese

            //>= 30 obese
            //>= 25 overweight
            //>= 18.5 normal weight
            //< 18.5 underweight

            if (BMI >= 30)
            {
                Console.WriteLine("Obese");
            }
            else if (BMI >= 25)
            {
                Console.WriteLine("overweight");
            }
            else if (BMI >= 18.5)
            {
                Console.WriteLine("normal weight");
            }
            else
            {
                Console.WriteLine("underweight");
            }
        }

        public void Compute_BMI2(string name, double weight, double height)
        {

            double BMI = weight / Math.Pow((height / 100), 2);


            Console.WriteLine($"Patient Name: {name} ");
            Console.WriteLine($"Patient Weight:{weight} ");
            Console.WriteLine($"Patient Height: {height}");
            Console.WriteLine($"Patient BMI: {BMI} ");



            //<18.5 underweight
            //>=25  <30 overweight
            //>=18.5 <25 normal  weight
            //>=30 obese

            //>= 30 obese
            //>= 25 overweight
            //>= 18.5 normal weight
            //< 18.5 underweight

            if (BMI >= 30)
            {
                Console.WriteLine("Obese");
            }
            else if (BMI >= 25)
            {
                Console.WriteLine("overweight");
            }
            else if (BMI >= 18.5)
            {
                Console.WriteLine("normal weight");
            }
            else
            {
                Console.WriteLine("underweight");
            }
        }


    }
}
