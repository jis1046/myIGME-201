using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE12_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myString= new MyClass();

            myString.setString("Hello World");
            Console.WriteLine(myString.GetString());    
        }
    }
}
