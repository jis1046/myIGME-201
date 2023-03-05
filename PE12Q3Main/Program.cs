using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PE12_Q3;

namespace PE12Q3Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myString = new MyClass();

            myString.setString("Hello World");
            Console.WriteLine(myString.GetString());
        }
    }
}
