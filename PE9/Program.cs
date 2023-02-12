using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            order order1;
            order1.unitCost= 100;
            order1.unitCount = 5;
            Console.WriteLine(order1.totalCost());
            

        }
            struct order
        {
            public string itemName;
            public int unitCount;
            public double unitCost;

            public double totalCost()
            {
                return unitCount * unitCost;
            }

            
        }


    }

}

