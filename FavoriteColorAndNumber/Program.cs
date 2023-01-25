using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorNameSpace
{
    namespace Color
    {
        //Class: NumberClass
        //Josh Samuel
        //Purpose: Class to contain User's favorite color
        //Restriction: None
        static class ColorClass
        {
            public static string sFavColor = null;
        }
    }
}

namespace FavoriteColorAndNumber
{
    //Class: Program
    //Josh Samuel
    //Purpose: Console Read/Write and Exception-handling Exercise 
    //Restriction: None
    static internal class Program
    {
        //Method: Main
        //Purpose: Prompt the user for their favorite color and number
        //         Output  their favorite color (in limited text colors) thier favorite number of times
        //Restriction: None
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Prompt the user for their fav color
            Console.Write("Enter your favorite color: \t");

            //Read from the console and store that in variable
            ColorNameSpace.Color.ColorClass.sFavColor = Console.ReadLine();

            //Prompt the user for their fav number

            //Read from the console and store that in variable
            sFavNum = Console.ReadLine();

            //note that we cannot pass npFavNum to TryParse became it does not match the method signature 
            bValid = int.TryParse(sFavNum, out nFavNum);

            //Change text to match their color
            switch(Calias.ColorClass.sFavColor)
            {
                case "red":
                case "Red":
                case "RED":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case "blue":
                    Console.ForegoundColor = ConsoleColor.Blue;
                    break;


            }
            //Output their fav color and number of times
            for(int i = 0; i < npFavNum: i +=1)
            {
                //Different ways to generate output
                //Appedning stgrings using the "+" operator
                Console.WriteLine("Your favorite color is " + Calias.COlorClass.sFAvColor + "! (appending)");

                //Embedding code blocks
                Console.WriteLine($"Your favoirte color is {Calias.ColorClass.sFavColor + "!"} (interpolation");
                    {
                        Calis.ColorClass
                    }
            }

            int x, y;
            y = 1;
            //x = ++y;
            //Output:
            //x = 2
            //y = 2

            x = y++;
            //Output:
            //x = 1
            //y = 2
        }
    }
}
