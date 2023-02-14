using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE6
{
    //Josh Samuel
    //PE6
    //Restriction None
    //Purpose: Create Guessing Game with parsing string to int
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating Random function
            Random rand = new Random();
            //generate a random number between 0 inclusive and 101 exclusive
            int randomNumber = rand.Next(0, 101);

            //Create for loop with 8 attempts
            for (int i = 1; i <= 8; i++)
            {
                //Ask uers input
                Console.WriteLine("Attempt " + i + ": Type number between 1 and 100");
                String input = Console.ReadLine();

                //Use try and catch for parsing string to int
                try
                {
                    //Parsing
                    int result = int.Parse(input);
                    Console.WriteLine();

                    //If statement for invalid inputs
                    if (result < 1 || result > 100)
                    {
                        Console.WriteLine("Invalid Guess");
                    }

                    //Tell the user if their guess was correct, high, or low
                    if (result < randomNumber)
                    {
                        Console.WriteLine("Number is below the answer.");
                        Console.WriteLine();
                    }

                    else if (result > randomNumber)
                    {
                        Console.WriteLine("Number is above the answer.");
                        Console.WriteLine();
                    }

                    if (result == randomNumber)
                    {
                        Console.WriteLine("Correct! You won in " + i + " attempts.");

                    }

                    //While loop to stop for loop if guess was correct
                    while (result == randomNumber)
                    {

                    }

                    //If attempts reach 8 then tells the users that they ran out of turns
                    if (i == 8)
                    {
                        Console.WriteLine("You ran out of eight turns. The answer was " + randomNumber);
                    }
                }

                //Tell users if there error with input
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }
    }
}
