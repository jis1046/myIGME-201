using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samuel_HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name1 = "Brain";
            int myInteger = 500;
            double myDouble = 5.5;

            Console.WriteLine("Josh Samuel ");
            Console.WriteLine(myInteger - myDouble);
          
            if (myInteger - myDouble < 500)
            {
                Console.WriteLine("myInteger is less than 500");
            }

            while(myInteger >= 400)
            {
               myInteger = myInteger - 10;
                Console.WriteLine(myInteger);
                
            }

        }
    }
}
