using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.week3.day2.OOP_Level3
{


    //Patient - Patient_test
    //Felids  Patient_name ,weight , height
    //Encapsulation - private fields and public properties
    //Methods: Get_BMI() , Get_Status()

    public class Student
    {

        public int Id { get; set; }
        public string Name { set;  get; }


        private double _mark;
        public double Mark { 
            get { 
                return _mark;
                }

            set {

                if (value >= 0)
                {
                    _mark = value;
                }
                else
                {
                    Console.WriteLine("Mark cannot be negative");
                }

            } 
        }

        private int _fullMark;
        public int FullMark
        {
            get
            {
                return _fullMark;
            }
            set
            {

                if (value >= 0)
                {
                    _fullMark = value;
                }
                else
                {
                    Console.WriteLine("Full mark cannot be negative");
                }

            }
        }

        public Student(string name, double mark, int fullMark)
        {
            Name = name;
            Mark = mark;
            FullMark = fullMark;
        }

        //public double Get_Mark()
        //{
        //    return Mark;
        //}
        //public int Get_FullMark() {
        //    return FullMark;
        //}

        //public void Set_Mark(int mark) {

        //    if(Mark>=0)
        //    {
        //        Mark = mark;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Mark cannot be negative");
        //    }

        //}
        //public void Set_FullMark(int fullMark)
        //{
        //    if (FullMark >= 0)
        //    {
        //        FullMark = fullMark;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Full mark cannot be negative");
        //    }

        //}


        public double Get_Pct()

        {
            double pct = (Mark / FullMark) * 100;
            return pct ;
        }

        public string Get_Grade()
        {
            double pct = Get_Pct();
            if (pct >= 90)
            {
                return "A";
            }
            else if (pct >= 80)
            {
                return "B";
            }
            else if (pct >= 70)
            {
                return "C";
            }
            else if (pct >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }



    }
}
