using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit1Q3
{
    //Step1: declare the delegate
    public delegate double ReadLineDelegate();
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Step 2 Create a delegate variable
            ReadLineDelegate num;

            Console.WriteLine("Enter 1 whole and 2 decimal numbers");
            Math.Round(double num;num,1);
            //Step 3 Assign the readline method to the delegate
            num = new ReadLineDelegate(Console.ReadLine);

            //Calling the delegate
            string readLine = num();

            Console.WriteLine(readLine);
        }
    }
}
