using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4
{

        //PE 4 Flow Control Question 2
        //Josh Samuel
        //Use code to answer question 2
        //Restriction: None
    internal class Program
    {
        static void Main(string[] args)
        {


            
            //Question #2

            //Variables
            int var1 = 11;
            int var2 = 12;

            //While Loop
            while(var1 >10 && var2 >10)
            {
                Console.Write("The first number: ");
                //Input
                 var1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("The second number: ");
                //Input
                 var2 = Convert.ToInt32(Console.ReadLine());

                //If statment to determine if one of variable is less than 10 make the statement true
                if(var1 > 10 && var2 > 10) 
                {
                    Console.WriteLine("Error: both numbers are greater than 10. Please enter two new numbers");
                }

                
            
            }
            //Tells the user the press any keys to end program
            Console.WriteLine("Press any key to end program");
            Console.ReadLine();

            








        }
    }
}
