using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.week4.day2.Cars
{
    public class Car : Vehicle
    {

        public int NumberOfDoors { get; set; }

        public Car(string brand, string model, double price, int numberOfDoors) : base(brand, model, price)
        {
            NumberOfDoors = numberOfDoors;
        }
        public string StartEngine()
        {
            return("Car Engine Started");
        }

    }
}
