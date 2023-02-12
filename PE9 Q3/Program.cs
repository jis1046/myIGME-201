using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Josh Samuel
//PE9 Q3
//Making delegate function
namespace PE9_Q3
{
    // Step1: declare the delegate
    public delegate string ReadLineDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {

            //Step 2 Create a delegate variable
            ReadLineDelegate readline;

            Console.WriteLine("Type the input");

            //Step 3 Assign the readline method to the delegate
            readline = new ReadLineDelegate(Console.ReadLine);

            //Calling the delegate
            string readLine = readline();


            //Prints delagate output
            Console.Write("Delagate: ");
            Console.WriteLine(readLine);
        }
    }
}
