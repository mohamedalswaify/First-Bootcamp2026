using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.week4.day2.Cars
{
    public class Vehicle
    {

        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { private get; set; }

        public Vehicle(string brand ,string model,double price)
        {
            Brand = brand;
            Model = model;
            Price = price;
        }

        public Vehicle()
        {
            Brand = "";
            Model = "";
            Price = 0;
        }
        public string DisplayDetails()
        {
           return($"Brand: {Brand}, Model: {Model}, Price: {Price}");
        }

        public double GetPrice()
        {
            return Price;
        }

    }
}
