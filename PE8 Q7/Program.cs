using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String word = "";
            String reverse = "";

            Console.WriteLine("Type any words");
            word = Console.ReadLine();

            int l = word.Length - 1;

            for (int i = l; i >= 0; i--)
            {
                reverse = reverse + word[i];
            }

            Console.WriteLine("Words in reverse order");
            Console.WriteLine(reverse);
        }
    }
}
