using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day2
{
    internal class Qiuz
    {
        static void Mainn()
        {

            //Qiuz
            // What is  5  * 6? 30
            //Correct 
            //Wrong

            Random random = new Random();

            int num1 = random.Next(1,11);
            int num2 = random.Next(1, 11);

            Console.WriteLine($"What is  {num1}  * {num2}?");
            int answer = Convert.ToInt32(Console.ReadLine());

            if(answer== num1*num2  )
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Wrong");
            }



            Console.ReadKey(true);
        }






    }
}
