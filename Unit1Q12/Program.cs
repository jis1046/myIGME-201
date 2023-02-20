using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit1Q12
{
    internal class Program
    {

        static bool GivenRaise(string name, ref double salary)
        {
            
           if(name == "Josh")
            {
                //salary increase if name matches my name
                salary += 19999.99;                                    
            }
            return true;
        }
        static void Main(string[] args)
        {
            string sName;
            double dSalary = 30000;

            //Ask user to type the name
            Console.WriteLine("Type your name");
            sName = Console.ReadLine();
            GivenRaise(sName, ref dSalary);//Call the function
            Console.WriteLine("Congratulate you got a raise and your new salary is " + dSalary);

        }
    }
}
