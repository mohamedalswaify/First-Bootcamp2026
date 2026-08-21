using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.week3.day2.OOP_Level3
{
    public class Room
    {

        public int Width;
        public int Length;

        //ctor
        public Room(int width , int length)
        {
            Width = width;
            Length = length;

        }


        public int Get_Area()
        { 
        int area = Width * Length;
            return area;

        }









    }
}
