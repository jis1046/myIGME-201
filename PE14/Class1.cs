using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE14
{
    internal class Class1:Interface1
    {
        public string myMethod()
        {
            return "Hello World";
        }
    }

    internal class Class2 : Interface1
    {
        public string myMethod()
        {
            return "Bye World";
        }

    }


}
