using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.week3.day3
{
    public class Patient
    {
        public string Patient_name { get; set; }
       
        private double _weight;
        public double Weight 
        {
            get
            {
                return _weight;
            }
            set
            {
                if ((value>0))
                {
                    _weight = value;
                }
                else
                {
                    Console.WriteLine("Weight cannot be negative or zero");
                }
            }

               
        }
        private double _height;
        public double Height 
        {
            get
            {
                return _height;
            }
            set{
                if ((value > 0))
                {
                    _height = value;
                }
                else
                {
                    Console.WriteLine("Height cannot be negative or zero");
                }

            }
        }


        public Patient(string patient_name,double weight ,double height)
        {

            Patient_name = patient_name;
            Weight = weight;
            Height = height;
        }


        public double Get_BMI()
        {
            return Weight / Math.Pow((Height / 100), 2);
        }

        public string Get_Status(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if ( bmi < 24.9)
            {
                return "Normal weight";
            }
            else if ( bmi < 29.9)
            {
                return "Overweight";
            }
            else
            {
                return "Obesity";
            }
        }








    }
}
