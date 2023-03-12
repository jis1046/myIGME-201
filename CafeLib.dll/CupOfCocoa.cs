using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib.dll
{
    public class CupOfCocoa: HotDrink, ITakeOrder
    {
        public static int numCups;
        bool marshmallows;
        private string source;

         string source
        {
            set;
        }

        public override void Steam()
        {

        }

        public override void AddSugar(byte amount)
        {

        }

        public void TakeOrder() 
        { 
        
        }

        public CupOfCocoa(bool marshmallows): base("Expensive Organic Brand")
        { 

        }
    }
}
