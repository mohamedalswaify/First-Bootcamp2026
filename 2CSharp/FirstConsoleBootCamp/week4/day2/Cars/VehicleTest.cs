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
            new Vehicle(),
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

            //Interface IEmployee
            //method Hello(),DisplayEmployeeDetails(),CalculateAnnualSalary()

            //Class Employee : IEmployee

            //Class FreeLancer : IEmployee,IPrintable
            //Feilds: Name,ProjectPrice
            //method DisplayEmployeeDetails(),CalculateAnnualSalary(),Hello(),Print()

            //----------------------------------------------------------

            // Interface  IVehicle 
            //methods:  DisplayDetails 

            //Class  Drone  :  IVehicle
            //Felids:   Model  
            //ctor 
            //Methods:  DisplayDetails

            //Car_Test 
            // Create new object  Drone in side the array of IVehicle

            //----------------------------------------------------------
            // Interface IAnimal
            //method MakeSound(),DisplayInfo()

            //Class Fish  : IAnimal
            //Feilds: Name,Color,IsFreshWater
            //method DisplayInfo() , MakeSound()

            //Class Bird  : IAnimal
            //Feilds: Name,Color,CanFly
            //method DisplayInfo() , MakeSound()

            //Test Class Animal_Test
            //Create object and add  IAnimal with Fish and Bird objects inside the array of IAnimal and call the methods

            //----------------------------------------------------------
            //Interface IAccount
            //method DisplayAccount() 

            //Class BankAccount implements IAccount

            //Class Wallet : IAccount
            //Felids:   Phone
            //method DisplayAccount()

            //Acoount_Test
            //Create an array of IAccount with 2 BankAccount and 2 Wallet



            Console.ReadKey();

        }
    }
}
