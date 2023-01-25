using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquashTheBugs
{
    // Class Program
    // Author: Josh Samuel
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            //Syntax Error: It does not have semicolon
            //int i = 0
            int i = 0;

            // loop through the numbers 1 through 10
            //Logic Error: For loop will run only number 1 through 9
            //for (i = 1; i < 10; ++i)
            for (i = 1; i <= 10; ++i)
            {
                // declare string to hold all numbers
                string allNumbers = null;

                // output explanation of calculation
                //Console.Write(i + "/" + i - 1 + " = ");
                Console.Write(i + "/" + (i - 1) + " = ");

                // output the calculation based on the numbers
                //Logic Error it cannot divide by zero
                //Can't Figure it out
                //Console.WriteLine(i / (i - 1));
                Console.WriteLine();

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // output all numbers which have been processed
                Console.WriteLine("These numbers have been processed: " + allNumbers);

                // increment the counter
                //Logic Error It already use in for loop. This statement would add another increment
                // i = i + 1;
                


            }

            // output all numbers which have been processed
            //Syntax Error: It does not have a plus sign between string and variable, also allNumber does not exist outside for loop if allNumber is set in for loop
            //Console.WriteLine("These numbers have been processed: " allNumbers);
            
        }
    }
}
