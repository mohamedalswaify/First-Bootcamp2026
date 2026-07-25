using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day3
{
    internal class Quiz_V2
    {

        static void Mainn()
        {
            Random random = new Random();
            int correctAnswer = 0;
            int numOfQuestions = 5;

           

            for (int x = 1; x <= numOfQuestions; x += 1)
            {
                int num1 = random.Next(1, 11);
                int num2 = random.Next(1, 11);

                Console.Write($"{x}.What is  {num1}  * {num2}?");
                int answer = Convert.ToInt32(Console.ReadLine());
                //----- Solution 1: Using Ternary Operator
                //string result = (answer == num1 * num2) ? "Correct" : "Wrong";

                //----- Solution 2: Using If-Else Statement
                string result;
                if (answer == num1 * num2)
                {
                    result = "Correct";
                    correctAnswer += 1;
                }
                else
                {
                    result = "Wrong";
                }

                Console.WriteLine(result);
            }



            Console.WriteLine($"Total Correct Answers: {correctAnswer}");
            Console.WriteLine($"Total Wrong Answers: {numOfQuestions - correctAnswer }");


        


            Console.ReadKey(true);
        }
    }
}
