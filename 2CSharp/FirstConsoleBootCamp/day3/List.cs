using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day3
{
    internal class List
    {
        static void Mainn()
        {

            int[] numbers = { 10, 20, 30, 40, 50, 60, 70,90,210 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }


           
       
           

            string[] names = new string[5];

            names[0] = "HTML";
            names[1] = "CSS";
            names[2] = "JS";
            names[3] = "C#";
            names[4] = "Python";


            foreach(string name in names)
            {
                Console.WriteLine(name);
            }



            List<int> list = new List<int>();


          
            list.Add(100);
            list.Add(200);
            list.Add(300);
            list.Add(400);
            list.Add(500);

            list[0] = 555;

            foreach (int i in list)
                Console.WriteLine(i);








            Console.ReadKey();
        }
    }
}
