using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.week3.day1.Return_Functions
{
    internal class Calling_Methods
    {

        static void Main()
        {
            Methods met = new Methods();


            //met.Hello();


            //Console.WriteLine("Enter num1: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter num1: ");
            //int num2 = int.Parse(Console.ReadLine());

            ////met.Sum2(num1, num2);
            //int res = met.Sum3(num1, num2);
            //Console.WriteLine(res);




            //----------------------Compute_Sal with  Parms------------

            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Employee Salary: ");
            double salary = double.Parse(Console.ReadLine());

            Console.Write("Enter Employee Bonus: ");
            double bonus = double.Parse(Console.ReadLine());

            double data = met.Compute_Sal3(name, salary, bonus);
            Console.WriteLine(data);
            //----------------------------------------------------




            Console.ReadKey();
        }



    }
}
