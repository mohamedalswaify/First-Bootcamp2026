using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day3
{
    internal class Compute_PCT_V3
    {
        static void Mainn()
        {
            List<string> list = new List<string>();

            for (int i = 1; i <= 5; i++)
            {

                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Student Mark:");
                double mark = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Student Full Mark:");
                double fullMark = double.Parse(Console.ReadLine());


                double percentage = (mark / fullMark) * 100;
               
                string Grade;

                if (percentage >= 85)
                {
                    Grade= ("Excellent");
                }

                else if (percentage >= 75)
                {
                    Grade=("Very Good");
                }
                else if (percentage >= 65)
                {
                    Grade = ("Good");
                }
                else if (percentage >= 50)
                {
                    Grade = ("Pass");
                }

                else
                {

                    Grade = ("Fail");
                }
                list.Add($" Student Name:  {name} \nyour  mark is: {mark} \nYour Percentage is:{percentage} %");


            }

            foreach (string item in list)
            {
                Console.WriteLine(item);
                Console.WriteLine();

            }

            Console.ReadKey();
        }
    }
}
