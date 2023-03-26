using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UnitTest2Q9;

namespace UnitTest2Q9
{
    internal class UnitTest2Q9
    {
        static void Main(string[] args)
        {
            Big bigMan = new Big();
            Guard pointGuard = new Guard();

            bigMan.myMethod(bigMan);

            pointGuard.myMethod(pointGuard);
            

            

        }
    }
}
