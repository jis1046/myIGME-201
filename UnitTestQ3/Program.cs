using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace UnitTestQ3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SortedList formula = new SortedList();
            double z = 0.0;

            for(double w = -2; w <= 0; w += 0.2)
            {
                for(double y = -1; y <= 1; y += 0.1)
                {
                    for(double x = 0; x <= 4; x += 0.1)
                    {
                        var formulaTuple = new Tuple<double, double, double>(w,y,x);
                        z = (4 * Math.Pow(Math.Round(y,1), 3.0)) + (2 * Math.Pow(Math.Round(x, 1), 2.0)) - (8 * Math.Round(w, 1)) + 7;
                        formula.Add(formulaTuple, z = Math.Round(z,3));
                    }

                }
            }

        }
    }
}
