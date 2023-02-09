using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 5
            /*Given the formula z = 3y^2 + 2x - 1 write a console application to calculate z for the following ranges of x and y:
            -1 <= x <= 1 in 0.1 increments
            1 <= y <= 4 in 0.1 increments
            Use a 3 - dimensional array double[,,] to store the values of x, y and z for each computation. */

            double x = 0;
            double y = 0;
            double z = 0;

            z = (((y * y) * 3) + (2 * x) - 1);

            int xindex = 0;
            int yindex = 0;
            int zindex = 0;

            double[,,] xyz = new double[21, 31, 3];

            for (x = -1; x <= 1; x += 0.1)
            {
                x = Math.Round(x, 1);
                yindex = 0;

                for (y = 1; y <= 4; y += 0.1)
                {
                    y = Math.Round(y, 1);

                    z = (((y * y) * 3) + (2 * x) - 1);

                    xyz[xindex, yindex, 0] = x;
                    xyz[xindex, yindex, 1] = y;
                    xyz[xindex, yindex, 2] = z;





                    yindex++;
                }
                xindex++;


            }
        }
    }
}
