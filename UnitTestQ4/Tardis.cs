using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestQ4
{
    public class Tardis : RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;
        double exteriorSurfaceArea;
        double interiorVolume;

        public byte WhichDrWho
        {
            get;
        }

        public string FemaleSideKick
        {
            get;
        }

        public void TimeTravel()
        {

        }

        public static bool operator ==(Tardis tardis1, Tardis tardis2)
        {
            return tardis1.whichDrWho == tardis2.whichDrWho;
        }

        public static bool operator !=(Tardis tardis1, Tardis tardis2)
        {
            return tardis1.whichDrWho != tardis2.whichDrWho;
        }

        public static bool operator <(Tardis tardis1, Tardis tardis2)
        {
            if(tardis1.whichDrWho == 10)
            {
                return false;
            }
            else if(tardis2.whichDrWho == 10)
            {
                return true;
            }
            
            return tardis1.whichDrWho < tardis2.whichDrWho;
        }

        public static bool operator >(Tardis tardis1, Tardis tardis2)
        {
            if (tardis1.whichDrWho == 10)
            {
                return true;
            }
            else if (tardis2.whichDrWho == 10)
            {
                return false;
            } 
            return tardis1.whichDrWho > tardis2.whichDrWho;
        }

        public static bool operator <=(Tardis tardis1, Tardis tardis2)
        {
            if (tardis1.whichDrWho == 10 && tardis2.whichDrWho != 10)
            {
                return false;
            }
            else if (tardis2.whichDrWho == 10 && tardis1.whichDrWho != 10)
            {
                return true;
            }

            return tardis1.whichDrWho <= tardis2.whichDrWho;
        }

        public static bool operator >=(Tardis tardis1, Tardis tardis2)
        {
            if (tardis1.whichDrWho == 10 && tardis2.whichDrWho != 10)
            {
                return true;
            }
            else if (tardis2.whichDrWho == 10 && tardis1.whichDrWho != 10)
            {
                return false;
            }

            return tardis1.whichDrWho >= tardis2.whichDrWho;
        }


    }
}
