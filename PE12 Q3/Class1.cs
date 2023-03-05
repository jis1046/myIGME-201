using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE12_Q3
{
    public class MyClass
    {
        private string myString;

        public void setString(string _myString)
        {
            myString = _myString;
        }
        
        public virtual string GetString()
        {
            return myString;
        }
    }

    public  class MyDerivedClass : MyClass 
    { 
        public override string GetString()
        {
           return base.GetString() + " (output from the derived class)";
        }
    }
}
