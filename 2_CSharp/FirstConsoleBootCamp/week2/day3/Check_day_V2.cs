using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day3
{
    internal class Check_day_V2
    {
        static void Mainn()
        {
            //Check_day_V2
            //Enter Your Day: 1 
            //1 Workday
            //2 Workday
            //3 Workday
            //4 Workday
            //5 Workday
            //6 Offday
            //7 Offday
            //Invaild Day

            Console.WriteLine("Enter Your Day:");
            int day = int.Parse(Console.ReadLine());
            string today = "";
            if (day >= 1 && day <= 5)
                today = ("Workday");

            else if (day == 6 || day == 7 )
                today = ("Offday");
            else
                today = ("Invaild Day");




            Console.ReadKey();
        }
    }
}
