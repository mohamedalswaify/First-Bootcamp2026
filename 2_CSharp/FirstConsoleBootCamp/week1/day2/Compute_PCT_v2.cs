using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day2
{
    internal class Compute_PCT_v2
    {
        static void Mainn()
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

            Console.ReadKey();
        }
    }
}
