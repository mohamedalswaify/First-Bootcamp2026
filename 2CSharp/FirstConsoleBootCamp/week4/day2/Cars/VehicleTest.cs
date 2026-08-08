using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.week4.day2.Cars
{
    public class VehicleTest
    {
        static void Mainn(string[] args)
        {
            //Vehicle vehicle = new Vehicle("Toyota", "Camry", 25000);
            //Car car = new Car("Honda", "Civic", 22000, 4);
            //Motorcycle motorcycle = new Motorcycle("Harley-Davidson", "Street 750", 7500, false);

            //Console.WriteLine($"{vehicle.DisplayDetails()},Price: {vehicle.GetPrice()}");
            //Console.WriteLine($"{car.DisplayDetails()},Price: {car.GetPrice()}, Engine: {car.StartEngine()}");
            //Console.WriteLine($"{motorcycle.DisplayDetails()},Price: {motorcycle.GetPrice()}, Wheelie: {motorcycle.DoWheelie()}");



            IList<Vehicle> vehicles = new List<Vehicle>()
            {
            new Vehicle("Toyota", "Camry", 25000),
            new Car("Honda", "Civic", 22000, 4),
            new Motorcycle("Harley-Davidson", "Street 750", 7500, false)
            };



            //Vehicle[] vehicles = 
            //{
            //new Vehicle("Toyota", "Camry", 25000),
            //new Car("Honda", "Civic", 22000, 4),
            //new Motorcycle("Harley-Davidson", "Street 750", 7500, false)
            //};

            foreach (var v in vehicles)
            {
                string details = $"{v.DisplayDetails()},Price: {v.GetPrice()}";
                if (v is Car c) //true  //false
                {
                    Console.Write(details);
                    Console.WriteLine($" Engine: {c.StartEngine()}");
                }
                else if (v is Motorcycle m)
                {
                    Console.Write(details);
                    Console.WriteLine($" Wheelie: {m.DoWheelie()}");
                }
                else
                {
                    Console.WriteLine(details);
                }

            }


            Console.ReadKey();

        }
    }
}
