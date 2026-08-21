using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day3
{
    internal class Check_day
    {
        static void Mainn()
        {
            //Check_day
            //Enter Your Day: 1 
            //1 Sunday
            //2 Monday
            //3 Tuesday
            //4 wednesday
            //5 Thurday
            //6 Friday
            //7 Saturday
            //Invaild Day

            Console.WriteLine("Enter Your Day:");
            int day = int.Parse(Console.ReadLine());
            string today = "";

            //if (day == 1)      Console.WriteLine("Sunday");
            //else if (day == 2) Console.WriteLine("Monday");
            //else if (day == 3) Console.WriteLine("Tuesday");
            //else if (day == 4) Console.WriteLine("wednesday");
            //else if (day == 5) Console.WriteLine("Thurday");
            //else if (day == 6) Console.WriteLine("Friday");
            //else if (day == 7) Console.WriteLine("Saturday");
            //else               Console.WriteLine("Invaild Day");

            //if (day == 1) 
            //    today= ("Sunday");
            //else if (day == 2) 
            //    today=("Monday");
            //else if (day == 3) 
            //    today = ("Tuesday");
            //else if (day == 4) 
            //    today = ("wednesday");
            //else if (day == 5) 
            //    today = ("Thurday");
            //else if (day == 6) 
            //    today = ("Friday");
            //else if (day == 7) 
            //    today = ("Saturday");
            //else 
            //    today = ("Invaild Day");

           

            switch (day)
            {
                case 1:
                    today = ("Sunday");
                    break;

                case 2:
                    today = ("Monday");
                    break;
                case 3:
                    today = ("Tuesday");
                    break;
                case 4:
                    today = ("wednesday");
                    break;
                case 5:
                    today = ("Thurday");
                    break;
                case 6:
                    today = ("Friday");
                    break;
                case 7:
                    today = ("Saturday");
                    break;

                default:
                    today = ("Invaild Day");
                    break;
            }

                Console.WriteLine(today);

    




        }
    }
}
