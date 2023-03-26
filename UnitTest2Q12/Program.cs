using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2Q12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string,DateTime> friendBirthdays = new SortedList<string, DateTime>();
            friendBirthdays.Add("Josh Samuel", new DateTime(2000, 9, 14));
            friendBirthdays.Add("Chris Jordan", new DateTime(2002, 1, 27));
            foreach (var birthday in friendBirthdays)
            {
                Console.WriteLine("Birthday: " + "{0} {1:MM/dd/yyyy}", birthday.Key, birthday.Value);
            }
        }
    }
}
