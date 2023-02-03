using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4_Question6
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>
    //PE4 Q6
    //Josh Samuel
    //Restriciton: none

    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            //set these variables to make while loop keep going until it a conditon stops
            double imagstartingPoint = -1.2;
            double imagendingPoint = 1.2;

            //While loop if user puts invalid values
            while(imagstartingPoint < imagendingPoint)
            {
                //Ask user to input imaginary starting and ending point
                Console.Write("Enter the value for Imaginary starting point (1.2): ");
                imagstartingPoint = double.Parse(Console.ReadLine());

                Console.Write("Enter the value for Imaginary ending point (-1.2): ");
                imagendingPoint = double.Parse(Console.ReadLine());
            }

            double imagIncre = (imagstartingPoint - imagendingPoint) / 48.0;

            //set these variables to make while loop keep going until it a conditon stops
            double realStartingPoint = 1.77;
            double realEndingPoint = -0.6;

            //While loop if user puts invalid values
            while (realStartingPoint > realEndingPoint)
            {
                //Ask user to input real starting and ending point
                Console.Write("Enter the value for Real starting point (-0.6): ");
                realStartingPoint = double.Parse(Console.ReadLine());

                Console.Write("Enter the value for Real ending point (1.77): ");
                realEndingPoint = double.Parse(Console.ReadLine());
            }

            double realIncre = (realEndingPoint - realStartingPoint) / 80.0;


            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;
            for (imagCoord = imagstartingPoint; imagCoord >= imagendingPoint; imagCoord -= imagIncre)
            {
                for (realCoord = realStartingPoint; realCoord <= realEndingPoint; realCoord += realIncre)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}
