using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib.dll
{
    public class Customer : IMood
    {
        string name;
        string creditCardNumber;

        string Mood
        {
            get;
        }
    }
}
