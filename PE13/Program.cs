using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE13
{
    //Josh Samuel
    //PE13
    //Restriction- Could not figure how add an object to the list
    internal class Program
    {

        static void Main(string[] args)
        {
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            Pets pets = new Pets();

            Random rand = new Random();

            for (int i = 1; i<=50; i++)
            {
                // 1 in 10 chance of adding an animal
                if (rand.Next(1, 11) == 1)
                {
                    pets.Add(pet());//Can't figure out how to add

                    if (rand.Next(0, 2) == 0)
                    {
                        // add a dog     
                        
                    }
                    else
                    {
                        // else add a cat

                    }
                }
                else
                {
                    // choose a random pet from pets and choose a random activity for the pet to do
                }
            }

        }
    }
}
