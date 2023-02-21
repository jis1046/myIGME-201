using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PE9Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string label1 = "warriors";
            int[] args1 = { 1, 2, 3, 4, 5 };
            bool showLabel1= true;
            Write();
            myFunction(label1, showLabel1, args1);
        }

        static bool Write()
        {
            Console.WriteLine("Text output from function.");
            return true;
        }

        static void myFunction(string label, bool showLabel, params int[] args)
        {
            if (showLabel)
            {
                Console.WriteLine(label);
            }

            foreach (int i in args)
            {
                Console.WriteLine("{0}", i);
            }
        }

    }
}
