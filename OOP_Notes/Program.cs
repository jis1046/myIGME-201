using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Notes
{
    interface MathFunctions
    {

    }
    class FactorialClass
    {
        public int nResult;

        public FactorialClass(int i)
        {
            nResult = Factorial(i);
        }

        private int Factorial(int v)
        {
            int returnVal;

            // base case: 0! = 1
            if (v == 0)
            {
                returnVal = 1;
            }
            else
            {
                returnVal = v * Factorial(v - 1);
            }

            return (returnVal);
        }

        public FactorialClass()
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /* string sNumber = null;
             int nNumber = 0;
             int nAnswer = 0;

             do
             {
                 Console.Write();
                 sNumber = Console.ReadLine();
             }
             while (!int.TryParse(sNumber, out nNumber) && nNumber <= 0);*/
            /*
                        int resultVar = 100;
                        int var1 = 20;
                        int var2 = 30;
                        int var3 = 10;
                        int var4 = 20;
                        int var5 = 3;
                        resultVar -= var1 + var2 * var3 % var4 - var5;
                        Console.WriteLine(resultVar);   
                        Console.WriteLine(var1 + var2 * var3 % var4 - var5);

                        double[][] dArray = new int[2][];
                        dArray[1] = new double[2];
                        dArray[2] = new double[1]

                        dArray[0][0] = 15;
                        dArray[1][2] = 5.67;
            */

            /* byte byteVal;
             short shortVal = -556;
             byteVal = (byte)shortVal;
             Console.WriteLine("byteVal = {0}", byteVal); */

            byte byteVal;
            short shortVal = -556;
            byteVal = checked((byte)shortVal);
            Console.WriteLine("byteVal = {0}", byteVal);

           /* byte byteVal;
            short shortVal = -556;
            byteVal = Convert.ToByte(shortVal);
            Console.WriteLine("byteVal = {0}", byteVal); */

            string $salary = "";
            string MAX_INT_# = "";

			string 99bottlesOfBeerOnTheWall = "";
            string # hashtag = "";
            string excitement! = "";
            string good&evil = "";

            $salary
            MAX_INT_#
			99bottlesOfBeerOnTheWall
# hashtag
            excitement!
            good & evil

        }
    }
}
