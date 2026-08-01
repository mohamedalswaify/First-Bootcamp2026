using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.week3.day2.OOP_Level3
{
    internal class Room_Test
    {

        static void Mainn()
        {


            //int width = 2;
            //int length = 3;
            //int area = width * length;
            //Console.WriteLine(area);


            //int width1 = 2;
            //int length1 = 3;
            //int area1 = width1 * length1;
            //Console.WriteLine(area1);


            //int area1 = Room_Area(2, 3);
            //Console.WriteLine(area1);


            //int area2 = Room_Area(3, 4);
            //Console.WriteLine(area2);



            Room r1 = new Room(2,3);
            Console.WriteLine(r1.Width);
            Console.WriteLine(r1.Length);
            int area= r1.Get_Area();
            Console.WriteLine(area);


            Room r2 = new Room(3, 4);
            Console.WriteLine(r2.Width);
            Console.WriteLine(r2.Length);
            int area2 = r2.Get_Area();
            Console.WriteLine(area2);


          





            Console.ReadKey();
        }



        static int Room_Area(int width , int length)
        {
            int area = width * length;
            return area;
        }



    }
}
