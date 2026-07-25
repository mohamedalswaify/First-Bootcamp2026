using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.level2
{
    internal class Calling
    {
        static void Main()
        {
          

             Methods methods = new Methods();

            Console.WriteLine("Select Option:");
            Console.WriteLine("1.System Hello");
            Console.WriteLine("2.System Employees");
            Console.WriteLine("3.System Students");
            Console.WriteLine("4.System Patients");
            int answer = int.Parse(Console.ReadLine());
            
            if (answer == 1)
            {
                methods.Hello();
            }
            else if (answer == 2) {
                methods.Compute_Sal();
            }
            else if (answer == 3)
            {
                methods.Compute_Pct();
            }
            else if (answer == 4)
            {
                methods.Compute_BMI();
            }
            else
            {
                Console.WriteLine("Invalid Option");
            }


            Console.ReadKey();
        }

            



    }


}
