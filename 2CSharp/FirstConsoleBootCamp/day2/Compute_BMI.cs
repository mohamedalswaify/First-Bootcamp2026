using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp
{
    internal class Compute_BMI
    {


        static void Mainn(string[] args)
        {


            // Enter Patient Name:
            // Enter Patient Weight: 87
            // Enter Patient Height: 187

            // BMI = weight /  (height/100)2

            // print Patient Name:
            //print Patient Weight:
            // print Patient Height:
            // print Patient BMI: 18 - 30

            Console.Write("Enter Patient Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Patient Weight: ");
            double weight = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter Patient Height: ");
            double height = double.Parse(Console.ReadLine());

            double BMI = weight / Math.Pow((height /100), 2);   


            Console.WriteLine($"Patient Name: {name} ");
            Console.WriteLine($"Patient Weight:{weight} " );
            Console.WriteLine($"Patient Height: {height}" );
            Console.WriteLine($"Patient BMI: {BMI} " );



            //<18.5 underweight
            //>=25  <30 overweight
            //>=18.5 <25 normal  weight
            //>=30 obese

            //>= 30 obese
            //>= 25 overweight
            //>= 18.5 normal weight
            //< 18.5 underweight

            if (BMI>=30)
            {
                Console.WriteLine("Obese");
            }
            else if(BMI>=25)
            {
                Console.WriteLine("overweight");
            }
            else if (BMI >= 18.5)
            {
                Console.WriteLine("normal weight");
            }
            else
            {
                Console.WriteLine("underweight");
            }


        







            Console.ReadKey(true);
        }   
    }
}
