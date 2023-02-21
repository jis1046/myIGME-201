using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE9Q4
{
    //Josh Sanuel
    //PE9 Q4
    //Purpose: Create program that prints the total price of an order using struct with function in it 
    //Restriction: none
    struct order
    {
        public string itemName;
        public int unitCount;
        public double unitCost;

        public void totalPrice(int unitCount, double unitCost)
        {
             Console.WriteLine(unitCount * unitCost);
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Declare list of struct order
            order list = new order { };

            //accesses and sets struct field
            list.unitCount = 5;
            list.unitCost = 250;

            //accesses struct methods
            list.totalPrice(list.unitCount, list.unitCost);

            

          

        }
    }
}
