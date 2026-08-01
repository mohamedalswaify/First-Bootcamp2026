using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.week3.day2.OOP_Level3
{
    internal class Student_Test
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Ali", 35, 50);
            s1.Mark = -25;
         

            Console.WriteLine($"Student Name: {s1.Name}, Mark: {s1.Mark}, Full Mark: {s1.FullMark}");
            
            Console.ReadKey();
        }
    }
}
