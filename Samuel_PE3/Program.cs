using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Samuel_PE3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value 1 : ");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value 2 : ");
            int value2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value 3 : ");
            int value3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value 4 : ");
            int value4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(value1 * value2 * value3 * value4);

        }
    }
}
