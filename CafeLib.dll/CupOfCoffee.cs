using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib.dll
{
    public class CupOfCoffee: HotDrink
    {
        string beanType;

        public override void Steam()
        {
            
        }
         public void TakeOrder()
        {

        }

        public CupOfCoffee(string brand): base(brand) 
        {

        }
    }
}
