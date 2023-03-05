using PE14;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE14Q3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Class2 class2 = new Class2();

            MyMethod(class1);
            MyMethod(class2);
        }

        public static void MyMethod(object myObject)
        {
            Interface1 interface1 = (Interface1)myObject;
            Console.WriteLine(interface1.myMethod());
            Console.WriteLine();
        }
    }
}
