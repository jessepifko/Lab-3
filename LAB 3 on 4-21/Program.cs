using System;
using System.Runtime.CompilerServices;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Lab 2! What is your name: ");
            string name = Console.ReadLine();

            while (true) // Validation
            {
                Console.WriteLine($"Hi {name}! Please enter a number between 1 and 100");
                int answer = int.Parse(Console.ReadLine());

                if (answer < 1 || answer > 100)
                {
                    Console.WriteLine($"Sorry {name} there was an error, please try again");
                }

                else if (answer % 2 != 0)
                {
                    Console.WriteLine($"{name}, {answer} is odd.");
                }
                else if (answer % 2 == 0 && answer < 25)
                {
                    Console.WriteLine($"{name}, the number is even and less 25");
                }
                else if (answer % 2 == 0 && answer >= 26 && answer <= 60)
                {
                    Console.WriteLine($"{name}, {answer} is even!");
                }
                else if (answer % 2 == 0 && answer > 60)
                {
                    Console.WriteLine($"{name}, {answer} is even!");
                }

                bool validInput = false;
                string cont = "";

                while (!validInput)
                {
                    Console.WriteLine($"{ name}, would you like to continue? Y/N");
                    cont = Console.ReadLine();

                    if (cont.ToLower() == "n")
                    {
                        validInput = true;
                    }
                    else if (cont.ToLower() == "y")
                    {
                        validInput = true;
                    }
                }
                if (cont == "n")
                {
                    break;
                }


            }









        }
    }
}
