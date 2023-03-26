using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestQ4
{
    public abstract class Phone
    {
        private string phoneNumber;
        public string address;

        public string PhoneNumber
        {
            set { phoneNumber= value; }
        }
        public abstract void Connect();




        public abstract void Disconnect();
        
    }
}
