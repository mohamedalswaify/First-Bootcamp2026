using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.week3.day3
{
    internal class Patient_Test
    {
        static void Mainn()
        {


            Patient p1 = new Patient("Ali", 70, 175);

          //  p1.Weight = -70;

            double bmi = p1.Get_BMI();
            string status = p1.Get_Status(bmi);

            Console.WriteLine($"Patient Name: {p1.Patient_name} ,BMI: {bmi}, Status: {status}");




            Console.ReadKey();
        }
    }
}
