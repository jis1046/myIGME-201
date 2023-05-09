using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
        class Program
        {

            class MathRound
        {
            public static double Round(double d, int n)
            {
                return Math.Round(d, n);
            }
        }
            public delegate double MyRounder(double d, int n);
            static void Main(string[] args)
            {
                // create variable of delegate function type 
                MyRounder myRounder;

            // your code here
            myRounder = (double d, int n) => Math.Round(d, n);
            Console.WriteLine(myRounder(4.648, 2));

            myRounder = Math.Round;
            Console.WriteLine(myRounder(2.4537, 3));

            myRounder = (d, n) => Math.Round(d, n);
            Console.WriteLine(myRounder(4.648931, 3));

            myRounder = (d, n) => { return Math.Round(d, n); };
            Console.WriteLine(myRounder(7.329, 2));

            myRounder = (double d, int n) => { return Math.Round(d, n); };
            Console.WriteLine(myRounder(7.329, 1));

            myRounder = delegate(double d, int n) { return Math.Round(d, n); };
            Console.WriteLine(myRounder(7.3292735, 4));

            myRounder = MathRound.Round;
            Console.WriteLine(myRounder(3.333, 2));

            double Round(double d, int n) => Math.Round(d, n);
            myRounder = Round;
            Console.WriteLine(myRounder(9.435, 2));



            





        }
        }
    

}
