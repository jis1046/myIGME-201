using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib.dll
{
    public abstract class HotDrink
    {
        bool instant;
        bool milk;
        private byte sugar;
        string size;


        public virtual void AddSugar(byte amount)
        {

        }

        public abstract void Steam();
        

        public HotDrink(string brand)
        {

        }
    }
}
