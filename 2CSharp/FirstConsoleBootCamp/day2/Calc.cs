using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day2
{
    internal class Calc
    {

        static void Mainn()
        {
            //Calc
            //Enter First Number: 10
            //Enter Second Number: 20
            //Enter Operator(+,-,*,/): +
            //result: 30



            Console.Write("Enter First Number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Enter Operator(+,-,*,/): ");
            string op = Console.ReadLine();


            if (op == "+")
            {
                double sum = num1 + num2;
                Console.Write($"Result:{sum} ");

            }
            else if (op == "-")
            {
                double minus = num1 - num2;
                Console.Write($"Result:{minus} ");
            }
            else if (op == "*")
            {
                double mulit = num1 * num2;
                Console.Write($"Result:{mulit} ");
            }
            else if (op == "/")
            {
                if (num2 != 0)
                {
                    double div = num1 / num2;
                    Console.Write($"Result:{div} ");
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed.");
                    
                }
            }
            else
            {
                Console.WriteLine("Invalid operator.");
            }


           




            Console.ReadKey();
        }
    }
}
