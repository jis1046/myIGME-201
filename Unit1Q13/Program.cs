using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit1Q12
{
    internal class Program
    {
        struct employee
        {
            public string sName;
            public double dSalary;
        }

        static bool GivenRaise(string sname, ref double dsalary)
        {

            if (sname == "Josh")
            {
                //salary increase if name matches my name
                dsalary += 19999.99;
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
