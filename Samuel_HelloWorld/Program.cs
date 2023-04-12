using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samuel_HelloWorld
{

        // PE1 Hello World
        // Josh Samuel
        // Purpose: Complaing and Running the Program
        //  Restriction: None
    internal class Program
    {
        //Main Method
        static void Main(string[] args)
        {
            //Variables
            String name1 = "Brain";
            int myInteger = 500;
            double myDouble = 5.5;

            Console.WrieLine("Josh Samuel ");
            Console.WriteLine(myInteger - myDouble);
          
            //If Statment 
            if (myInteger - myDouble < 500)
            {
                Console.WriteLine("myInteger is less than 500");
            }

            //While Loop
            Console.WriteLine();
            Console.WriteLine("While loop");

            while (myInteger > 400)
            {
               myInteger = myInteger - 10;
                Console.WriteLine(myInteger);
                
            }

            //For Loop
            Console.WriteLine();
            Console.WriteLine("For loop");

            for (int i = 0; i < 10; i++)
            {
                myInteger += 10;
                Console.WriteLine(myInteger);
            }

        }
    }
}
