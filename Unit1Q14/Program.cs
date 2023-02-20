using Microsoft.Win32;
using System;

namespace UT1_BugSquash
{
    //Josh Samuel
    //Unit test 1 Q14
    //Can't figure the source of stack overflow
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function

        //Power method must be present before main program so main can call power method
        
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            //int nY no semicolon
            int nY;
            int nAnswer;

            int Power(int nBase, int nExponent)
            {
                int returnVal = 0;
                int nextVal = 0;

                // the base case for exponents is 0 (x^0 = 1)
                if (nExponent == 0)
                {
                    // return the base case and do not recurse
                    returnVal = 0;
                }
                else
                {
                    // compute the subsequent values using nExponent-1 to eventually reach the base case
                    nextVal = Power(nBase, nExponent + 1);

                    // multiply the base with all subsequent values
                    returnVal = nBase * nextVal;
                }

                //returnVal; does not has a return
                return returnVal;
            }


            //Console.WriteLine(This program calculates x ^ y.); Does not has quote marks in console
            Console.WriteLine("This program calculates x ^ y.");


            do
            {
                Console.Write("Enter a whole number for x: ");
                //Console.ReadLine(); sNumber was not initialized in the while loop below
                sNumber = Console.ReadLine();
            }  //while (!int.TryParse(sNumber, out nX));
                 while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
            } //while (int.TryParse(sNumber, out nX)); wrong variable should be nY not nX and while statement does not have !
            while (!int.TryParse(sNumber, out nY));

            // compute the exponent of the number using a recursive function
            nAnswer = Power(nX, nY);
            

            Console.WriteLine("{nX}^{nY} = {nAnswer}");
            
        }
    }
}
