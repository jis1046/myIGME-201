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

            //Change text to match their color

            //Output their fav color and number of times
        }
    }
}
