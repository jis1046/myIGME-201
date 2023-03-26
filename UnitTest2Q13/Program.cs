using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2Q13
{
    internal class Program
    {
        class MyClass
        {

            public MyClass ShallowCopy()
            {
                return (MyClass) this.MemberwiseClone();
            }
        }
        static void Main(string[] args)
        {
            MyClass objectA = new MyClass();
            MyClass objectB;
            objectB = objectA.ShallowCopy();
        }
    }
}
