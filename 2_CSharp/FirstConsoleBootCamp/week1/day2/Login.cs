using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day2
{
    internal class Login
    {

        static void Mainn()
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();


            if (username == "admin" && password == "12345")
            {
                Console.WriteLine("Login Successful");
            }
            else
            {
                Console.WriteLine("Login Failed");
            }

           


            Console.ReadKey(true);
        }
    }

}