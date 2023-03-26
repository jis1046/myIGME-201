using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestQ4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tardis t = new Tardis();
            PhoneBooth p = new PhoneBooth();
            UsePhone(t);
            UsePhone(p);
        }

        static void UsePhone(object obj)
        {
            PhoneInterface phoneinterface = (PhoneInterface)obj;
            phoneinterface.MakeCall();
            phoneinterface.HangUp();

            if(obj is PhoneBooth)
            {
                PhoneBooth pb = (PhoneBooth)obj;
                pb.OpenDoor();  
            }

            else if (obj is Tardis)
            {
                Tardis ts = (Tardis)obj;
                ts.TimeTravel();
            }
        }
    }
}
