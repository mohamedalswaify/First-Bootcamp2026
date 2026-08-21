using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.week4.day2.Cars
{
    public class Motorcycle : Vehicle
    {

        public bool HasSideCar { get; set; }

        public Motorcycle(string brand, string model, double price, bool hasSideCar) : base(brand, model, price)
        {
            HasSideCar = hasSideCar;
        }

        public string DoWheelie()
        {
            return "Motorcycle is doing a wheelie!";
        }

        public string DoWheelie(int durationInSeconds)
        {
            return $"Motorcycle is doing a wheelie for {durationInSeconds} seconds!"
   }
                }
}
