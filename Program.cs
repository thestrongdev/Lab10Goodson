using System;

namespace Lab10Goodson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Circle Class");
            double numberCircles = 0;
            bool keepGoing = true;

            do
            {

                Console.WriteLine("\nPlease enter a value for the circle radius: ");

                string userRadius = Console.ReadLine();

                if (!Validator.IsDouble(userRadius))
                {
                    Console.WriteLine("Please try again and enter a numerical value");
                    continue;
                }
                else
                {
                    double.TryParse(userRadius, out double radius);
                    var theCircle = new Circle(radius);
                    numberCircles += 1;
                    Console.WriteLine();
                    Console.WriteLine(theCircle.CalculateFormattedCircumference());
                    Console.WriteLine(theCircle.CalculateFormattedArea());
                    Console.WriteLine();
                    keepGoing = ContinueCircling();
                }

            } while (keepGoing) ;

            Console.WriteLine($"You created {numberCircles} circle object(s)");
        }

        static bool ContinueCircling()
        {
            Console.WriteLine("\nWould you like to get dimension from another circle?");

            do
            {
                string userChoice = Console.ReadLine();

                if (userChoice.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("GOODBYE!");
                    return false;
                }
                else if (userChoice.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("that's not a valid input. please enter y or n");
                }

            } while (true);
        }

        
    }
}
